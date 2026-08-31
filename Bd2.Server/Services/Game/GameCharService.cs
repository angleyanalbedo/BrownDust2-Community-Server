using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Game;
using Bd2.Server.DAO.Game;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SqlSugar;
using Bd2.Server.Model;

namespace Bd2.Server.Services.Game;

public class GameCharService : IGameCharService
{
	private readonly ILogger<GameCharService> _logger;

	private readonly ISqlSugarClient _db;

	private readonly IMapper _mapper;

	public GameCharService(ISqlSugarClient db, ILogger<GameCharService> logger, IMapper mapper)
	{
		_mapper = mapper;
		_db = db;
		_logger = logger;
	}

	public async Task<GameActionResult> CharLevelUp(CharLevelUpRequest charLevelUp, string uid)
	{
		CharInfoDao charInfoDao = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao it) => it.Uid == long.Parse(uid) && it.InvenIndex == charLevelUp.InvenIndex);
		CharTable charData = CharManager.GetCharData(charInfoDao.Id);
		int num = 0;
		foreach (ItemDBInfo item in charLevelUp.HolyWaterInfo)
		{
			switch (item.Id)
			{
			case 7:
				num += 200 * item.Count;
				break;
			case 8:
				num += 700 * item.Count;
				break;
			case 9:
				num += 2000 * item.Count;
				break;
			}
		}
		CharInfoDao levelUp = CharManager.CharLevelUp(charInfoDao, charData.CharGrowthId, num);
		await _db.Updateable(levelUp).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new CharLevelUpResponse
		{
			CharInfo = _mapper.Map<CharDBInfo>(levelUp)
		});
	}

	public async Task<GameActionResult> CharClassUp(CharClassUpRequest charClassUp, string uid)
	{
		CharInfoDao charInfoDao = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao it) => it.Uid == long.Parse(uid) && it.InvenIndex == charClassUp.InvenIndex);
		CharTable charData = CharManager.GetCharData(charInfoDao.Id);
		charInfoDao.Id = charData.NextCharId;
		await _db.Updateable(charInfoDao).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new CharClassUpResponse
		{
			CharInfo = _mapper.Map<CharDBInfo>(charInfoDao)
		});
	}

	public async Task<GameActionResult> CostumeUse(CostumeUseRequest use, string uid)
	{
		foreach (CostumeUseInfo costumeUseInfo in use.CostumeUseInfo)
		{
			await (from x in _db.Updateable<CostumeInfoDao>().SetColumns((CostumeInfoDao x) => x.UseChar == (long?)null)
				where x.UseChar == (long?)costumeUseInfo.CharIndex
				select x).ExecuteCommandAsync();
			await (from x in _db.Updateable<CostumeInfoDao>().SetColumns((CostumeInfoDao x) => x.UseChar == (long?)costumeUseInfo.CharIndex)
				where x.InvenIndex == costumeUseInfo.CostumeIndex
				select x).ExecuteCommandAsync();
			await (from x in _db.Updateable<CharInfoDao>().SetColumns((CharInfoDao x) => x.UseCostume == costumeUseInfo.CostumeIndex)
				where x.InvenIndex == costumeUseInfo.CharIndex
				select x).ExecuteCommandAsync();
		}
		return ResultUtil.CreateResult(new CostumeUseResponse());
	}

	public async Task<GameActionResult> CostumeNodeActivation(CostumeNodeActivationRequest open, string uid)
	{
		CostumeInfoDao costumeInfoDao = await _db.Queryable<CostumeInfoDao>().SingleAsync((CostumeInfoDao x) => x.InvenIndex == open.CostumeInvenIndex);
		List<int> list = new List<int>();
		if (costumeInfoDao.PotentialId == null)
		{
			list.Add(open.Id);
		}
		else
		{
			list.AddRange(JsonConvert.DeserializeObject<int[]>(costumeInfoDao.PotentialId));
			list.Add(open.Id);
		}
		costumeInfoDao.PotentialId = JsonConvert.SerializeObject(list);
		await _db.Updateable(costumeInfoDao).ExecuteCommandAsync();
		return ResultUtil.CreateResult(new CostumeNodeActivationResponse());
	}

	public async Task<GameActionResult> CostumePotentialConnect(CostumePotentialConnectRequest req, string uid)
	{
		List<CharInfoDao> charInfoDaos = new List<CharInfoDao>();
		foreach (CostumePotentialConnectInfo costumePotentialConnectInfo in req.CostumePotentialConnectInfo)
		{
			CharInfoDao charInfoDao = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == costumePotentialConnectInfo.InvenIndex);
			charInfoDao.ConnectPotentialCostume = costumePotentialConnectInfo.CostumeId;
			await _db.Updateable(charInfoDao).ExecuteCommandAsync();
			charInfoDaos.Add(charInfoDao);
		}
		CostumePotentialConnectResponse costumePotentialConnectResponse = new CostumePotentialConnectResponse();
		costumePotentialConnectResponse.CharInfo.AddRange(_mapper.Map<List<CharDBInfo>>(charInfoDaos));
		return ResultUtil.CreateResult(costumePotentialConnectResponse);
	}

	public async Task<GameActionResult> CharImprintLevelUp(CharImprintLevelUpRequest req, string uid)
	{
		CharInfoDao charInfoDao = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == req.CharInvenIndex);
		CharAwakeInfoDao charAwakeInfoDao = await _db.Queryable<CharAwakeInfoDao>().SingleAsync((CharAwakeInfoDao x) => x.OwnerIndex == long.Parse(uid) && x.UniqueCharId == charInfoDao.UniqueCharId);
		if (charAwakeInfoDao == null)
		{
			CharAwakeInfoDao charAwakeInfoDao2 = new CharAwakeInfoDao
			{
				OwnerIndex = long.Parse(uid),
				UniqueCharId = charInfoDao.UniqueCharId
			};
			switch (req.Slot)
			{
			case 1:
				charAwakeInfoDao2.ImprintSlot1Level = req.TargetLevel;
				break;
			case 2:
				charAwakeInfoDao2.ImprintSlot2Level = req.TargetLevel;
				break;
			case 3:
				charAwakeInfoDao2.ImprintSlot3Level = req.TargetLevel;
				break;
			}
			await _db.Insertable(charAwakeInfoDao2).ExecuteCommandAsync();
		}
		else
		{
			switch (req.Slot)
			{
			case 1:
				charAwakeInfoDao.ImprintSlot1Level = req.TargetLevel;
				break;
			case 2:
				charAwakeInfoDao.ImprintSlot2Level = req.TargetLevel;
				break;
			case 3:
				charAwakeInfoDao.ImprintSlot3Level = req.TargetLevel;
				break;
			}
			await _db.Updateable(charAwakeInfoDao).ExecuteCommandAsync();
		}
		BuyItem(req.ItemInfo.ToList(), long.Parse(uid));
		return ResultUtil.CreateResult(new CharImprintLevelUpResponse());
	}

	public async Task<GameActionResult> CharAwakeActive(CharAwakeActiveRequest req, string uid)
	{
		CharInfoDao charInfoDao = await _db.Queryable<CharInfoDao>().SingleAsync((CharInfoDao x) => x.InvenIndex == req.CharInvenIndex);
		await (from x in _db.Updateable<CharAwakeInfoDao>().SetColumns((CharAwakeInfoDao x) => x.IsAwake == 1)
			where x.OwnerIndex == charInfoDao.Uid && x.UniqueCharId == charInfoDao.UniqueCharId
			select x).ExecuteCommandAsync();
		BuyItem(req.ItemInfo.ToList(), long.Parse(uid));
		return ResultUtil.CreateResult(new CharAwakeActiveResponse());
	}

	private void BuyItem(List<ItemDBInfo> items, long uid)
	{
		foreach (ItemDBInfo item in items)
		{
			if (item.Type == 4)
			{
				(from x in _db.Updateable<UserInfoDao>().SetColumns((UserInfoDao x) => x.Gold == x.Gold - (long)item.Count)
					where x.OwnerIndex == uid
					select x).ExecuteCommand();
			}
			else
			{
				(from x in _db.Updateable<ItemInfoDao>().SetColumns((ItemInfoDao x) => x.Count == x.Count - item.Count)
					where x.InvenIndex == item.InvenIndex
					select x).ExecuteCommand();
			}
		}
	}
}
