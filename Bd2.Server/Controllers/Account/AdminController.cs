using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Bd2.Server.DAO.Game;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Enums;
using Bd2.Server.iServices.Account;
using Bd2.Server.Model.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlSugar;

namespace Bd2.Server.Controllers.Account;

[ApiController]
[Route("api/[controller]/[Action]")]
public class AdminController : ControllerBase
{
	private readonly ILogger<AdminController> _logger;
	private readonly IAdminService _adminService;
	private readonly ISqlSugarClient _db;

	public AdminController(ILogger<AdminController> logger, IAdminService adminService, ISqlSugarClient db)
	{
		_logger = logger;
		_adminService = adminService;
		_db = db;
	}

	[HttpPost]
	[AllowAnonymous]
	public Dictionary<string, object> Login([FromBody] AdminLoginDto dto)
	{
		return _adminService.AdminLogin(dto);
	}

	[HttpGet]
	[Authorize(AuthenticationSchemes = "AdminCookie")]
	public async Task<Dictionary<string, object>> PlayerList(int page = 1, int pageSize = 20, string keyword = "")
	{
		return await _adminService.GetPlayerList(page, pageSize, keyword);
	}

	[HttpGet]
	[Authorize(AuthenticationSchemes = "AdminCookie")]
	public async Task<Dictionary<string, object>> PlayerDetail(long ownerIndex)
	{
		return await _adminService.GetPlayerDetail(ownerIndex);
	}

	[HttpPost]
	[Authorize(AuthenticationSchemes = "AdminCookie")]
	public async Task<Dictionary<string, object>> UpdatePlayer([FromBody] UpdatePlayerDto dto)
	{
		return await _adminService.UpdatePlayer(dto);
	}

	[HttpPost]
	[Authorize(AuthenticationSchemes = "AdminCookie")]
	public async Task<Dictionary<string, object>> UpdateChar([FromBody] UpdateCharDto dto)
	{
		return await _adminService.UpdateChar(dto);
	}

	[HttpPost]
	[Authorize(AuthenticationSchemes = "AdminCookie")]
	public async Task<Dictionary<string, object>> SendMail([FromBody] AdminSendMailDto dto)
	{
		return await _adminService.AdminSendMail(dto);
	}

	[HttpGet]
	[Authorize(AuthenticationSchemes = "AdminCookie")]
	public async Task<Dictionary<string, object>> ServerStats()
	{
		return await _adminService.GetServerStats();
	}

	[HttpPost]
	[Authorize(AuthenticationSchemes = "AdminCookie")]
	public async Task<Dictionary<string, object>> DeletePlayer([FromBody] Dictionary<string, long> body)
	{
		if (body.TryGetValue("ownerIndex", out long ownerIndex))
		{
			return await _adminService.DeletePlayer(ownerIndex);
		}

		return new Dictionary<string, object>
		{
			{ "code", 400 },
			{ "msg", "参数错误" }
		};
	}

	/// <summary>
	/// 物品名称搜索（从 ItemLocalInfo 表查询）
	/// 先运行 tools/import_local_text.py 导入数据
	/// </summary>
	[HttpGet]
	[Authorize(AuthenticationSchemes = "AdminCookie")]
	public IActionResult CharacterSearch(string q = "", int limit = 20, string language = "zh-CN")
	{
		if (string.IsNullOrWhiteSpace(q)) return Ok(new { code = 0, data = Array.Empty<object>() });
		var chars = CharManager.GetAll().Select(x => new { Table = x, Name = CharManager.GetDisplayName(x, language) }).Where(x => int.TryParse(q, out var id) ? x.Table.Id == id : x.Name.Contains(q, StringComparison.OrdinalIgnoreCase)).Take(Math.Clamp(limit, 1, 100));
		return Ok(new { code = 0, data = chars.Select(x => new { id = x.Table.Id, name = x.Name }) });
	}

	[HttpGet]
	[Authorize(AuthenticationSchemes = "AdminCookie")]
	public async Task<IActionResult> ItemSearch(string q = "", int limit = 20, string language = "zh-CN", int? type = null)
	{
		if (string.IsNullOrWhiteSpace(q) || q.Length < 1)
		{
			return Content(JsonSerializer.Serialize(new { code = 0, data = new List<object>() }), "application/json");
		}

		// CostumeTable also contains boss/monster appearances. Resolve them
		// separately so they are never returned as normal player costumes.
		if (type == (int)ItemType.Costume)
		{
			var costumeResults = CostumeManager.GetAll()
				.Where(x => x.Id.ToString().Contains(q, StringComparison.OrdinalIgnoreCase) ||
						NameTextManager.GetText(x.CostumeNameTextId, language).Contains(q, StringComparison.OrdinalIgnoreCase))
				.Select(x => new { Resolution = InventoryItemResolver.Resolve(type.Value, x.Id, language), x.Id })
				.Where(x => x.Resolution.Category == InventoryItemCategory.PlayerCostume)
				.Take(Math.Clamp(limit, 1, 100))
				.Select(x => new { id = x.Id, type, name = x.Resolution.Name });
			return Ok(new { code = 0, data = costumeResults });
		}

		// 尝试按 ID 搜索
		if (int.TryParse(q, out var searchId))
		{
			var byId = await _db.Queryable<ItemLocalInfoDao>()
				.Where(x => x.Id == searchId)
				.FirstAsync();
			if (byId != null)
			{
				var result = new List<object> { BuildSearchResult(byId, language) };
				return Content(JsonSerializer.Serialize(new { code = 0, data = result }), "application/json");
			}
		}

		// 按名称模糊搜索（优先中文，其次韩文、英文）
		var items = await _db.Queryable<ItemLocalInfoDao>()
			.Where(x =>
				(x.TextCn != null && x.TextCn.Contains(q)) ||
				(x.TextKr != null && x.TextKr.Contains(q)) ||
				(x.TextEn != null && x.TextEn.Contains(q)) ||
				(x.TextJp != null && x.TextJp.Contains(q)) ||
				(x.TextTw != null && x.TextTw.Contains(q))
			)
			.Take(limit)
			.ToListAsync();

		var data = items.Select(x => BuildSearchResult(x, language)).ToList();
		if (data.Count == 0)
		{
			var designItems = ItemDesignManager.Search(q, limit, language, type);
			return Ok(new { code = 0, data = designItems.Select(x => new { id = x.Id, type = x.Type, name = x.Name }) });
		}
		return Content(JsonSerializer.Serialize(new { code = 0, data }), "application/json");
	}

	private static object BuildSearchResult(ItemLocalInfoDao item, string language)
	{
		var normalized = language?.ToLowerInvariant();
		var name = normalized switch
		{
			"ko" or "kr" or "ko-kr" => item.TextKr,
			"en" or "en-us" or "en-gb" => item.TextEn,
			"ja" or "jp" or "ja-jp" => item.TextJp,
			"zh-tw" or "tw" => item.TextTw,
			_ => item.TextCn
		};
		name = !string.IsNullOrWhiteSpace(name) ? name
			: !string.IsNullOrWhiteSpace(item.TextCn) ? item.TextCn
			: !string.IsNullOrWhiteSpace(item.TextKr) ? item.TextKr
			: !string.IsNullOrWhiteSpace(item.TextEn) ? item.TextEn
			: !string.IsNullOrWhiteSpace(item.TextJp) ? item.TextJp
			: !string.IsNullOrWhiteSpace(item.TextTw) ? item.TextTw
			: $"ID:{item.Id}";
		return new { id = item.Id, name };
	}
}
