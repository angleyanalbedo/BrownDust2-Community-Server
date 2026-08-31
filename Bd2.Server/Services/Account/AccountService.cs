using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Account;
using Bd2.Server.DAO.Account;
using Bd2.Server.DAO.Game;
using EasyTool;
using Microsoft.Extensions.Logging;
using SqlSugar;
using Bd2.Server.Model.Dto;

namespace Bd2.Server.Services.Account;

public class AccountService : IAccountService
{
	private readonly ILogger<AccountService> _logger;

	private readonly ISqlSugarClient _db;

	public AccountService(ILogger<AccountService> logger, ISqlSugarClient db)
	{
		_logger = logger;
		_db = db;
	}

	public Dictionary<string, object> Login(AccountDto accountDto)
	{
        _logger.LogInformation("登录请求 {}", accountDto.ToString());
		string text = "";
		AccountDao accountDao = _db.Queryable<AccountDao>().Single((AccountDao x) => x.UserName == accountDto.userName);
		if (accountDao != null)
		{
			if (accountDto.password != accountDao.Password)
			{
				return new Dictionary<string, object>
				{
					{ "code", 400 },
					{ "msg", "密码错误" }
				};
			}
			text = accountDao.Uid.ToString();
		}
		else
		{
			accountDao = new AccountDao
			{
				UserName = accountDto.userName,
				Password = accountDto.password
			};
			text = _db.Insertable(accountDao).ExecuteReturnIdentity().ToString();
		}
		string[] array = new string[6];
		array[0] = text;
		array[1] = "5063";
		array[2] = "WEB";
		array[3] = "KR";
		array[5] = TimestampUtil.GetCurrentTimestamp().ToString();
		array[4] = AesUtils.Sha1Hash(array[0] + array[5]);
		string s = string.Join("|", array);
		return new Dictionary<string, object>
		{
			{ "code", 200 },
			{
				"token",
				Convert.ToBase64String(Encoding.UTF8.GetBytes(s))
			},
			{ "msg", "ok" }
		};
	}

	public async Task<Dictionary<string, object>> SendMail(SendMailDto dto)
	{
		_logger.LogInformation("发送邮件请求 {}", dto.uid);
		UserInfoDao userInfoDao = await _db.Queryable<UserInfoDao>().SingleAsync((UserInfoDao x) => x.UserId == dto.uid);
		if (userInfoDao == null)
		{
			return new Dictionary<string, object>
			{
				{ "code", 400 },
				{ "msg", "用户错误" }
			};
		}
		MailInfoDao insertObj = new MailInfoDao
		{
			Uid = userInfoDao.OwnerIndex,
			Type = 2,
			MailId = 1,
			SenderText = "",
			TitleText = "发福利",
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
		await _db.Insertable(insertObj).ExecuteCommandAsync();
		return new Dictionary<string, object>
		{
			{ "code", 200 },
			{ "msg", "ok" }
		};
	}
}
