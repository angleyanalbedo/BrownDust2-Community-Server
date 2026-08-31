using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.iServices.Game;
using Bd2.Server.Model;
using EasyTool;
using Google.Protobuf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using SqlSugar;

namespace Bd2.Server.Controllers.Game;

/// <summary>Handles the local Neon access-token lifecycle and game-session sign-in.</summary>
[ApiController]
[Authorize]
[Route("Game/[Action]")]
public class UserAuthController : ControllerBase
{
	private readonly ILogger<UserAuthController> _logger;
	private readonly ISqlSugarClient _db;
	private readonly IGameUserService _gameUserService;

	public UserAuthController(ILogger<UserAuthController> logger, ISqlSugarClient db, IGameUserService gameUserService)
	{
		_logger = logger;
		_db = db;
		_gameUserService = gameUserService;
	}

	private static string BuildToken(string uid)
	{
		int num = 1;
		List<Claim> list = new List<Claim>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<Claim> span = CollectionsMarshal.AsSpan(list);
		span[0] = new Claim("user", uid);
		DateTime value = DateTime.Now.AddSeconds(86400.0);
		byte[] bytes = Encoding.UTF8.GetBytes("1bece8b1c0cfa6ed404d0473d920f2a8");
		SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
		SigningCredentials signingCredentials = new SigningCredentials(key, "HS256");
		JwtSecurityToken token = new JwtSecurityToken("blue", "blue", list, null, value, signingCredentials);
		return new JwtSecurityTokenHandler().WriteToken(token);
	}

	private async Task<string> CheckAccessTokenAsync(string accessToken)
	{
		if (string.IsNullOrWhiteSpace(accessToken)) return "";

		string[] array = accessToken.Split("|", StringSplitOptions.None);
		if (array.Length != 6 || !long.TryParse(array[0], out var memberId)) return "";
		if (array[4] != AesUtils.Sha1Hash(array[0] + array[5])) return "";

		var dbMain = ((SqlSugarScope)_db).GetConnectionScope("main");
		var exists = await dbMain.Queryable<Bd2.Server.DAO.Account.NeonAccountDao>()
			.Where(x => x.MemberId == memberId && x.AccessToken == accessToken)
			.AnyAsync();
		return exists ? array[0] : "";
	}

	[HttpPut]
	[AllowAnonymous]
	public async Task<GameActionResult> JoinUser([FromBody] string data)
	{
		_logger.LogInformation("JoinUser called, data length: {Length}", data?.Length ?? 0);
		JoinUserRequest joinUserRequest;
		try
		{
			joinUserRequest = ProtoUtil.Deserialize<JoinUserRequest>(data);
			_logger.LogInformation("JoinUser request: AccessToken={Token}", joinUserRequest.AccessToken);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "JoinUser deserialize failed");
			return ResultUtil.CreateErrorResult();
		}

		string uid = await CheckAccessTokenAsync(joinUserRequest.AccessToken);
		_logger.LogInformation("JoinUser token check: uid={Uid}", uid);
		if (uid == "") return ResultUtil.CreateErrorResult();

		Response.Cookies.Append("token", BuildToken(uid));
		var result = await _gameUserService.JoinUser(uid);
		_logger.LogInformation("JoinUser result: errorType={ErrorType}", result.errorType);
		return result;
	}

	[HttpPut]
	[AllowAnonymous]
	public async Task<GameActionResult> LoginUser([FromBody] string data)
	{
		LoginUserRequest loginUserRequest = ProtoUtil.Deserialize<LoginUserRequest>(data);
		_logger.LogInformation("LoginUser {}", loginUserRequest);
		string uid = await CheckAccessTokenAsync(loginUserRequest.AccessToken);
		if (uid == "") return ResultUtil.CreateErrorResult();

		Response.Cookies.Append("token", BuildToken(uid));
		return await _gameUserService.LoginUser(uid);
	}

	[HttpPut]
	[AllowAnonymous]
	public GameActionResult RefreshToken([FromBody] string data)
	{
		RefreshTokenRequest request = ProtoUtil.Deserialize<RefreshTokenRequest>(data);
		string[] array = request.AccessToken.Split("|", StringSplitOptions.None);
		if (array.Length != 6 || !long.TryParse(array[0], out var memberId) || array[4] != AesUtils.Sha1Hash(array[0] + array[5]))
			return ResultUtil.CreateErrorResult();

		array[5] = TimestampUtil.GetCurrentTimestamp().ToString();
		array[4] = AesUtils.Sha1Hash(array[0] + array[5]);
		var refreshedAccessToken = string.Join("|", array);
		var dbMain = ((SqlSugarScope)_db).GetConnectionScope("main");
		dbMain.Updateable<Bd2.Server.DAO.Account.NeonAccountDao>()
			.SetColumns(x => x.AccessToken == refreshedAccessToken)
			.Where(x => x.MemberId == memberId && x.AccessToken == request.AccessToken)
			.ExecuteCommand();

		return ResultUtil.CreateResult(new RefreshTokenResponse { AccessToken = refreshedAccessToken }.ToByteArray(), 186);
	}
}
