using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Account;
using Bd2.Server.DAO.Account;
using Bd2.Server.DAO.Game;
using Bd2.Server.Model.Dto;
using EasyTool;
using Microsoft.IdentityModel.Tokens;
using SqlSugar;

namespace Bd2.Server.Services.Account;

public class AdminService : IAdminService
{
	private readonly ISqlSugarClient _db;

	public AdminService(ISqlSugarClient db)
	{
		_db = db;
	}

	public Dictionary<string, object> AdminLogin(AdminLoginDto dto)
	{
		AccountDao accountDao = _db.Queryable<AccountDao>()
			.Single(x => x.UserName == dto.userName);

		if (accountDao == null)
		{
			return new Dictionary<string, object>
			{
				{ "code", 400 },
				{ "msg", "账号不存在" }
			};
		}

		if (accountDao.Password != dto.password)
		{
			return new Dictionary<string, object>
			{
				{ "code", 400 },
				{ "msg", "密码错误" }
			};
		}

		if (accountDao.Role < 1)
		{
			return new Dictionary<string, object>
			{
				{ "code", 403 },
				{ "msg", "无管理员权限" }
			};
		}

		string token = BuildAdminToken(accountDao.Uid.ToString(), accountDao.UserName, accountDao.Role);

		return new Dictionary<string, object>
		{
			{ "code", 200 },
			{ "msg", "ok" },
			{ "token", token },
			{ "userName", accountDao.UserName },
			{ "role", accountDao.Role }
		};
	}

	public async Task<Dictionary<string, object>> GetPlayerList(int page, int pageSize, string keyword)
	{
		var mainDb = ((SqlSugarScope)_db).GetConnectionScope("main");
		var accounts = await mainDb.Queryable<NeonAccountDao>().ToListAsync();
		var emailByMemberId = System.Linq.Enumerable.GroupBy(
			accounts.Where(x => x.MemberId > 0 && !string.IsNullOrWhiteSpace(x.Email)),
			x => x.MemberId)
			.ToDictionary(x => x.Key, x => x.First().Email);
		var matchingMemberIds = string.IsNullOrWhiteSpace(keyword)
			? new List<long>()
			: accounts
				.Where(x => !string.IsNullOrWhiteSpace(x.Email) &&
					x.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase))
				.Select(x => x.MemberId)
				.Where(x => x > 0)
				.Distinct()
				.ToList();

		var query = _db.Queryable<UserInfoDao>();

		if (!string.IsNullOrWhiteSpace(keyword))
		{
			query = query.Where(x => x.UserId.Contains(keyword) || matchingMemberIds.Contains(x.OwnerIndex));
		}

		var total = await query.CountAsync();
		var users = await query
			.OrderByDescending(x => x.LoginDate)
			.Skip((page - 1) * pageSize)
			.Take(pageSize)
			.ToListAsync();
		var list = users.Select(x => new Dictionary<string, object>
			{
				{ "ownerIndex", x.OwnerIndex },
				{ "userId", x.UserId },
				{ "email", emailByMemberId.TryGetValue(x.OwnerIndex, out var email) ? email : "" },
				{ "gold", x.Gold },
				{ "freeJewelry", x.FreeJewelry },
				{ "jewelry", x.Jewelry },
				{ "exp", x.Exp },
				{ "levelReward", x.LevelReward },
				{ "blockDate", x.BlockDate },
				{ "blockReason", x.BlockReason },
				{ "joinTime", x.JoinTime },
				{ "loginDate", x.LoginDate }
			}).ToList();

		return new Dictionary<string, object>
		{
			{ "code", 200 },
			{ "total", total },
			{ "list", list }
		};
	}

	public async Task<Dictionary<string, object>> GetPlayerDetail(long ownerIndex)
	{
		var user = await _db.Queryable<UserInfoDao>()
			.Where(x => x.OwnerIndex == ownerIndex)
			.FirstAsync();

		if (user == null)
		{
			return new Dictionary<string, object>
			{
				{ "code", 404 },
				{ "msg", "玩家不存在" }
			};
		}

		var chars = await _db.Queryable<CharInfoDao>()
			.Where(x => x.Uid == ownerIndex)
			.ToListAsync();

		var equips = await _db.Queryable<EquipInfoDao>()
			.Where(x => x.Uid == ownerIndex)
			.ToListAsync();

		var items = await _db.Queryable<ItemInfoDao>()
			.Where(x => x.Uid == ownerIndex)
			.ToListAsync();

		var decks = await _db.Queryable<DeckInfoDao>()
			.Where(x => x.Uid == ownerIndex)
			.ToListAsync();

		return new Dictionary<string, object>
		{
			{ "code", 200 },
			{ "user", user },
			{ "chars", chars },
			{ "equips", equips },
			{ "items", items },
			{ "decks", decks }
		};
	}

	public async Task<Dictionary<string, object>> UpdatePlayer(UpdatePlayerDto dto)
	{
		var user = await _db.Queryable<UserInfoDao>()
			.Where(x => x.OwnerIndex == dto.ownerIndex)
			.FirstAsync();

		if (user == null)
		{
			return new Dictionary<string, object>
			{
				{ "code", 404 },
				{ "msg", "玩家不存在" }
			};
		}

		var updateObj = new UserInfoDao { OwnerIndex = dto.ownerIndex };

		if (dto.gold.HasValue) updateObj.Gold = dto.gold.Value;
		if (dto.freeJewelry.HasValue) updateObj.FreeJewelry = dto.freeJewelry.Value;
	 if (dto.jewelry.HasValue) updateObj.Jewelry = dto.jewelry.Value;
		if (dto.exp.HasValue) updateObj.Exp = dto.exp.Value;
		if (dto.blockDate.HasValue) updateObj.BlockDate = dto.blockDate.Value;
		if (dto.blockReason.HasValue) updateObj.BlockReason = dto.blockReason.Value;

		await _db.Updateable(updateObj)
			.Where(x => x.OwnerIndex == dto.ownerIndex)
			.ExecuteCommandAsync();

		return new Dictionary<string, object>
		{
			{ "code", 200 },
			{ "msg", "ok" }
		};
	}

	public async Task<Dictionary<string, object>> UpdateChar(UpdateCharDto dto)
	{
		var charInfo = await _db.Queryable<CharInfoDao>()
			.Where(x => x.InvenIndex == dto.invenIndex)
			.FirstAsync();

		if (charInfo == null)
		{
			return new Dictionary<string, object>
			{
				{ "code", 404 },
				{ "msg", "角色不存在" }
			};
		}

		var updateObj = new CharInfoDao { InvenIndex = dto.invenIndex };

		if (dto.level.HasValue) updateObj.Level = dto.level.Value;
		if (dto.hp.HasValue) updateObj.Hp = dto.hp.Value;
		if (dto.talentLevel.HasValue) updateObj.TalentLevel = dto.talentLevel.Value;

		await _db.Updateable(updateObj)
			.Where(x => x.InvenIndex == dto.invenIndex)
			.ExecuteCommandAsync();

		return new Dictionary<string, object>
		{
			{ "code", 200 },
			{ "msg", "ok" }
		};
	}

	public async Task<Dictionary<string, object>> AdminSendMail(AdminSendMailDto dto)
	{
		UserInfoDao userInfoDao = await _db.Queryable<UserInfoDao>()
			.SingleAsync(x => x.UserId == dto.uid);

		if (userInfoDao == null)
		{
			return new Dictionary<string, object>
			{
				{ "code", 400 },
				{ "msg", "用户不存在" }
			};
		}

		MailInfoDao mailObj = new MailInfoDao
		{
			Uid = userInfoDao.OwnerIndex,
			Type = 2,
			MailId = 1,
			SenderText = "Admin",
			TitleText = dto.title ?? "管理员邮件",
			MessageText = "",
			RewardExpireTime = 1882926205000L,
			ItemType = dto.type,
			ItemId = dto.itemId,
			ItemCount = dto.count,
			IsOpen = 0,
			OpenTime = 0L,
			CreateTime = TimestampUtil.GetCurrentTimestamp(),
			HistoryDeleteTime = 0L,
			IsCash = 0
		};

		await _db.Insertable(mailObj).ExecuteCommandAsync();

		return new Dictionary<string, object>
		{
			{ "code", 200 },
			{ "msg", "ok" }
		};
	}

	public async Task<Dictionary<string, object>> GetServerStats()
	{
		var playerCount = await _db.Queryable<UserInfoDao>().CountAsync();
		var charCount = await _db.Queryable<CharInfoDao>().CountAsync();
		var equipCount = await _db.Queryable<EquipInfoDao>().CountAsync();
		var itemCount = await _db.Queryable<ItemInfoDao>().CountAsync();
		var mailCount = await _db.Queryable<MailInfoDao>().CountAsync();
		var accountCount = await _db.Queryable<AccountDao>().CountAsync();

		var todayStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, DateTimeKind.Local);
		long todayStartTs = new DateTimeOffset(todayStart).ToUnixTimeMilliseconds();
		var todayPlayers = await _db.Queryable<UserInfoDao>()
			.Where(x => x.LoginDate >= todayStartTs)
			.CountAsync();

		return new Dictionary<string, object>
		{
			{ "code", 200 },
			{ "playerCount", playerCount },
			{ "charCount", charCount },
			{ "equipCount", equipCount },
			{ "itemCount", itemCount },
			{ "mailCount", mailCount },
			{ "accountCount", accountCount },
			{ "todayPlayers", todayPlayers }
		};
	}

	public async Task<Dictionary<string, object>> DeletePlayer(long ownerIndex)
	{
		var user = await _db.Queryable<UserInfoDao>()
			.Where(x => x.OwnerIndex == ownerIndex)
			.FirstAsync();

		if (user == null)
		{
			return new Dictionary<string, object>
			{
				{ "code", 404 },
				{ "msg", "玩家不存在" }
			};
		}

		await _db.Deleteable<UserInfoDao>().Where(x => x.OwnerIndex == ownerIndex).ExecuteCommandAsync();
		await _db.Deleteable<CharInfoDao>().Where(x => x.Uid == ownerIndex).ExecuteCommandAsync();
		await _db.Deleteable<EquipInfoDao>().Where(x => x.Uid == ownerIndex).ExecuteCommandAsync();
		await _db.Deleteable<ItemInfoDao>().Where(x => x.Uid == ownerIndex).ExecuteCommandAsync();
		await _db.Deleteable<DeckInfoDao>().Where(x => x.Uid == ownerIndex).ExecuteCommandAsync();
		await _db.Deleteable<MailInfoDao>().Where(x => x.Uid == ownerIndex).ExecuteCommandAsync();

		return new Dictionary<string, object>
		{
			{ "code", 200 },
			{ "msg", "ok" }
		};
	}

	private static string BuildAdminToken(string uid, string userName, int role)
	{
		var claims = new List<Claim>
		{
			new Claim("user", uid),
			new Claim("userName", userName),
			new Claim("role", role.ToString())
		};

		DateTime expires = DateTime.Now.AddSeconds(86400.0);
		byte[] keyBytes = Encoding.UTF8.GetBytes("1bece8b1c0cfa6ed404d0473d920f2a8");
		SymmetricSecurityKey key = new SymmetricSecurityKey(keyBytes);
		SigningCredentials signingCredentials = new SigningCredentials(key, "HS256");

		JwtSecurityToken token = new JwtSecurityToken("blue", "blue", claims, null, expires, signingCredentials);
		return new JwtSecurityTokenHandler().WriteToken(token);
	}
}
