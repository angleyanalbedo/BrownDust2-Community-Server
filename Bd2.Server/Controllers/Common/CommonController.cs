using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Bd2.Server.Common;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.Common.Utils;
using Bd2.Server.DAO.Account;
using Bd2.Server.Model.Game;
using Google.Protobuf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SqlSugar;

namespace Bd2.Server.Controllers.Common;

[ApiController]
[Route("[controller]")]
public class CommonController : ControllerBase
{
	private readonly ILogger<CommonController> _logger;
	private readonly ISqlSugarClient _db;

	public CommonController(ILogger<CommonController> logger, ISqlSugarClient db)
	{
		_logger = logger;
		_db = db;
	}

	[HttpPost("~/StateCheckInfoJson")]
	[HttpPost("StateCheckInfoJson")]
	public Dictionary<string, object> StateCheckInfoJson()
	{
		_logger.LogInformation("StateCheckInfoJson called");
		return new Dictionary<string, object>
		{
			{ "country", "CN" },
			{ "errorType", 0 },
			{ "errorMessage", "" }
		};
	}

	[HttpPost("~/api/accounts/v3/weblogin/login/webtoken")]
	public Dictionary<string, object> GetWebToken([FromForm] string neon_web_token)
	{
		if (string.IsNullOrWhiteSpace(neon_web_token))
		{
			return new Dictionary<string, object> { { "result_code", "999" }, { "result_msg", "INVALID_TOKEN" } };
		}

		string text;
		string[] array;
		try
		{
			text = Encoding.UTF8.GetString(Convert.FromBase64String(neon_web_token));
			array = text.Split("|", StringSplitOptions.None);
		}
		catch (FormatException)
		{
			return new Dictionary<string, object> { { "result_code", "999" }, { "result_msg", "INVALID_TOKEN" } };
		}
		if (array.Length != 6 || !int.TryParse(array[0], out var memberId) || AesUtils.Sha1Hash(array[0] + array[5]) != array[4])
		{
			return new Dictionary<string, object> { { "result_code", "999" }, { "result_msg", "INVALID_TOKEN" } };
		}

		_logger.LogInformation("GetWebToken: member_id={MemberId}", memberId);
		WebToken webToken = new WebToken();
		Member member = new Member
		{
			member_id = memberId
		};
		webToken.access_token = text;
		webToken.member = member;
		return new Dictionary<string, object>
		{
			{ "result_code", "000" },
			{ "result_msg", "API_OK" },
			{ "value", webToken }
		};
	}

	[HttpPost("~/api/gpg/check/user")]
	public Dictionary<string, object> CheckUser()
	{
		_logger.LogInformation("CheckUser called");
		return new Dictionary<string, object>
		{
			{ "result_code", "000" },
			{ "result_msg", "API_OK" },
			{ "value", false }
		};
	}

	[HttpPost("~/api/accounts/v3/weblogin/sendAuthEmail")]
	public async Task<IActionResult> SendAuthEmail([FromForm] string email, [FromForm] string lang, [FromForm] int app_id)
	{
		email = email.Trim().ToLowerInvariant();
		_logger.LogInformation("SendAuthEmail: email={Email}, lang={Lang}, app_id={AppId}", email, lang, app_id);

		try
		{
			var dbMain = ((SqlSugarScope)_db).GetConnectionScope("main");
			_logger.LogInformation("Got Main connection scope");

			var existing = await dbMain.Queryable<NeonAccountDao>().SingleAsync(x => x.Email == email);
			if (existing == null)
			{
				await dbMain.Insertable(new NeonAccountDao
				{
					Email = email,
					CreateTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
				}).ExecuteCommandAsync();
			}

			return Content(
				JsonConvert.SerializeObject(new
				{
					result_code = "000",
					result_msg = "API_OK",
					value = "SUCCESS"
				}),
				"application/json",
				Encoding.UTF8);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "SendAuthEmail failed");
			return Content(
				JsonConvert.SerializeObject(new
				{
					result_code = "999",
					result_msg = ex.Message
				}),
				"application/json",
				Encoding.UTF8);
		}
	}

	[HttpPost("~/api/accounts/v3/weblogin/login/emailpincode")]
	public async Task<IActionResult> EmailPinCodeLogin([FromForm] string email, [FromForm] string pin_number, [FromForm] int app_id)
	{
		_logger.LogInformation("EmailPinCodeLogin: email={Email}, pin={Pin}, app_id={AppId}", email, pin_number, app_id);

		try
		{
			var dbMain = ((SqlSugarScope)_db).GetConnectionScope("main");

			email = email.Trim().ToLowerInvariant();
			var account = await dbMain.Queryable<NeonAccountDao>().SingleAsync(x => x.Email == email);
			if (account == null)
			{
				account = new NeonAccountDao
				{
					Email = email,
					CreateTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
				};
				await dbMain.Insertable(account).ExecuteCommandAsync();
				account = await dbMain.Queryable<NeonAccountDao>().SingleAsync(x => x.Email == email);
			}

			// A Neon member id is the identity used by JoinUser/LoginUser as the game UID.
			// It must therefore be unique per email; a fixed value makes every account share one save.
			var memberId = (long)account.Uid;
			var ts = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
			var hash = Bd2.Server.Common.Utils.AesUtils.Sha1Hash(memberId + ts);
			var accessToken = $"{memberId}|0|0|0|{hash}|{ts}";

			account.AccessToken = accessToken;
			account.MemberId = memberId;
			await dbMain.Updateable(account).ExecuteCommandAsync();

			_logger.LogInformation("Login success: member_id={MemberId}, email={Email}", memberId, email);

			return Content(
				JsonConvert.SerializeObject(new
				{
					result_code = "000",
					result_msg = "API_OK",
				value = new
				{
					member_id = memberId,
					access_token = accessToken,
					member = new
					{
						member_id = memberId,
						reg_path = "EMAIL",
						is_guest_login = false
					}
				}
				}),
				"application/json",
				Encoding.UTF8);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "EmailPinCodeLogin failed");
			return Content(
				JsonConvert.SerializeObject(new
				{
					result_code = "999",
					result_msg = ex.Message
				}),
				"application/json",
				Encoding.UTF8);
		}
	}

	[HttpPost("~/api/accounts/v3/weblogin/autologin/email")]
	public IActionResult AutoLoginEmail([FromForm] string provider, [FromForm(Name = "access_token")] string accessToken)
	{
		accessToken = GetRequestAccessToken(accessToken);
		_logger.LogInformation("AutoLoginEmail: provider={Provider}, hasAccessToken={HasAccessToken}", provider, !string.IsNullOrWhiteSpace(accessToken));
		return AutoLoginByAccessToken(accessToken, "AutoLoginEmail");
	}

	[HttpPost("~/api/accounts/neo/autologin")]
	public IActionResult AutoLogin([FromForm(Name = "access_token")] string accessToken)
	{
		accessToken = GetRequestAccessToken(accessToken);
		_logger.LogInformation("AutoLogin: hasAccessToken={HasAccessToken}", !string.IsNullOrWhiteSpace(accessToken));
		return AutoLoginByAccessToken(accessToken, "AutoLogin");
	}

	private IActionResult AutoLoginByAccessToken(string accessToken, string source)
	{
		var dbMain = ((SqlSugarScope)_db).GetConnectionScope("main");
		// NeonHttp automatically sends the locally persisted neon_access_token as a
		// form field.  That token, not provider=EMAIL, identifies the previous account.
		var account = string.IsNullOrWhiteSpace(accessToken)
			? null
			: dbMain.Queryable<NeonAccountDao>().Single(x => x.AccessToken == accessToken);

		if (account == null)
		{
			_logger.LogWarning("{Source}: persisted token does not match a local account", source);
			return Content(
				JsonConvert.SerializeObject(new
				{
					result_code = "999",
					result_msg = "NO_SAVED_LOGIN"
				}),
				"application/json",
				Encoding.UTF8);
		}

		// Accounts created before unique member ids were implemented all contain
		// MemberId=1.  The saved token identifies the account safely, so migrate it
		// here and return a replacement token for the account's own game UID.
		if (account.MemberId != account.Uid)
		{
			account.MemberId = account.Uid;
			account.AccessToken = CreateAccessToken(account.MemberId);
			dbMain.Updateable(account).ExecuteCommand();
			_logger.LogInformation("{Source}: migrated legacy account {Email} to member_id={MemberId}", source, account.Email, account.MemberId);
		}
		_logger.LogInformation("{Source}: restored member_id={MemberId} for email={Email}", source, account.MemberId, account.Email);

		return Content(
			JsonConvert.SerializeObject(new
			{
				result_code = "000",
				result_msg = "API_OK",
				value = new
				{
					member_id = account.MemberId,
					access_token = account.AccessToken,
					unreg_status = "N",
					member = new
					{
						member_id = account.MemberId,
						crt_dt = account.CreateTime,
						reg_path = "EMAIL",
						reg_nation = "CN",
						is_guest_login = false
					}
				}
			}),
			"application/json",
			Encoding.UTF8);
	}

	private static string CreateAccessToken(long memberId)
	{
		var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
		return $"{memberId}|0|0|0|{AesUtils.Sha1Hash(memberId + timestamp)}|{timestamp}";
	}

	private string GetRequestAccessToken(string formAccessToken)
	{
		// NeonHttp sends its persisted neon_access_token through SetHeaders(), not
		// through the form body. Keep the form fallback for external clients.
		return !string.IsNullOrWhiteSpace(formAccessToken)
			? formAccessToken
			: Request.Headers["access_token"].ToString();
	}

	[HttpPost("~/api/members/analytics")]
	public IActionResult Analytics()
	{
		return Content("{}", "application/json", Encoding.UTF8);
	}

	[HttpPost("~/api/eula/{id}/agree")]
	public IActionResult EulaAgree(int id)
	{
		_logger.LogInformation("EulaAgree: id={Id}", id);
		return Content(
			JsonConvert.SerializeObject(new
			{
				result_code = "000",
				result_msg = "API_OK"
			}),
			"application/json",
			Encoding.UTF8);
	}

	[HttpPut("~/MaintenanceInfo")]
	[HttpPut("MaintenanceInfo")]
	public async Task<IActionResult> MaintenanceInfo()
	{
		_logger.LogInformation("MaintenanceInfo called");
		using var ms = new System.IO.MemoryStream();
		await Request.Body.CopyToAsync(ms);
		var body = ms.ToArray();

		var req = new HttpRequestMessage(HttpMethod.Put, "https://mt.bd2.pmang.cloud/MaintenanceInfo")
		{
			Content = new ByteArrayContent(body)
		};
		req.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
		var resp = await OfficialDns.SendAsync(req);
		var json = await resp.Content.ReadAsStringAsync();
		_logger.LogInformation("MaintenanceInfo forwarded");
		return Content(json, "application/json", Encoding.UTF8);
	}

	[HttpPut("~/ServerInfo")]
	[HttpPut("ServerInfo")]
	public async Task<IActionResult> ServerInfo()
	{
		_logger.LogInformation("ServerInfo called");
		var gameServer = AppSettings.app("GameServer").TrimEnd('/') + "/Game/";
		using var ms = new System.IO.MemoryStream();
		await Request.Body.CopyToAsync(ms);
		var body = ms.ToArray();

		try
		{
			var req = new HttpRequestMessage(HttpMethod.Put, "https://mt.bd2.pmang.cloud/ServerInfo")
			{
				Content = new ByteArrayContent(body)
			};
			req.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
			var resp = await OfficialDns.SendAsync(req);
			var json = await resp.Content.ReadAsStringAsync();
			var obj = JObject.Parse(json);
			var data = Convert.FromBase64String(obj["data"].ToString());
			var serverInfo = ServerInfoResponse.Parser.ParseFrom(data);
			if (serverInfo.InfoList.Count > 0)
			{
				serverInfo.InfoList[0].GameServerInfo = gameServer;
			}
			var newBytes = serverInfo.ToByteArray();
			obj["data"] = Convert.ToBase64String(newBytes);
			obj["length"] = newBytes.Length;
			_logger.LogInformation("ServerInfo forwarded");
			return Content(obj.ToString(Formatting.None), "application/json", Encoding.UTF8);
		}
		catch (Exception ex)
		{
			_logger.LogWarning(ex, "ServerInfo forward failed");
			return Content("{\"error\":\"ServerInfo unavailable\"}", "application/json", Encoding.UTF8);
		}
	}

	[HttpPost("~/api/gpg/price/localization")]
	public Dictionary<string, object> GetPriceLocalization()
	{
		_logger.LogInformation("GetPriceLocalization called");
		return new Dictionary<string, object>
		{
			{ "result_code", "000" },
			{ "result_msg", "API_OK" },
			{ "value", new { skus = new object() } }
		};
	}

	[HttpPost("~/api/billing/v2/xsolla/auth")]
	public IActionResult XsollaAuth()
	{
		_logger.LogInformation("XsollaAuth called");
		var token = Guid.NewGuid().ToString("N");
		return Content(
			JsonConvert.SerializeObject(new
			{
				result_code = "000",
				result_msg = "API_OK",
				value = new
				{
					token = token,
					expires_in = 3600
				}
			}),
			"application/json",
			Encoding.UTF8);
	}

	[HttpPost("~/api/billing/mycard/check/mycard/nation")]
	public IActionResult MyCardNation()
	{
		// NeonPurchaseXsolla.FetchLocaleAsync only reads value.paymentNation and
		// maps it to a locale. Local servers do not provide real MyCard billing.
		_logger.LogInformation("MyCardNation called");
		return Content(
			JsonConvert.SerializeObject(new
			{
				result_code = "000",
				result_msg = "API_OK",
				value = new { paymentNation = "US" }
			}),
			"application/json",
			Encoding.UTF8);
	}
}
