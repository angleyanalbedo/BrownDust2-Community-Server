using Bd2.Server.DAO.Game;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Enums;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SqlSugar;
using Bd2.Server.iServices.Game;

namespace Bd2.Server.Pages.Admin;

[Authorize(AuthenticationSchemes = "AdminCookie")]
public class CheatModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
    private readonly ISqlSugarClient _db;
    private readonly IContentUnlockService _contentUnlockService;
    private readonly IScheduleAdminService _scheduleAdminService;
    public CheatModel(ISqlSugarClient db, IContentUnlockService contentUnlockService, IScheduleAdminService scheduleAdminService)
    {
        _db = db;
        _contentUnlockService = contentUnlockService;
        _scheduleAdminService = scheduleAdminService;
    }

    public List<UserInfoDao> Players { get; private set; } = new();
    public List<MonsterHuntOption> MonsterHunts { get; private set; } = new();
    public List<EventOption> Events { get; private set; } = new();
    public List<GachaOption> Gachas { get; private set; } = new();
    public string? Message { get; private set; }

    public sealed record MonsterHuntOption(int Id, int MonsterId, int PackId, string Name);
    public sealed record EventOption(int EventType, int EventId, int EventSubId, string Name);
    public sealed record GachaOption(int RowId, string Name, int Type, int SortId, bool Enabled, bool IsPermanent);

    public void OnGet()
    {
        LoadPlayers();
        LoadScheduleOptions();
    }

    public IActionResult OnPostMaxFriendship(long uid)
    {
        var rows = _db.Queryable<FriendshipInfoDao>().Where(x => x.Uid == uid).ToList();
        foreach (var row in rows)
        {
            row.Level = 10;
            row.Exp = 0;
            _db.Updateable(row).ExecuteCommand();
        }
        TempData["CheatMessage"] = $"已将 {rows.Count} 个亲密度角色设置为 10 级。";
        return RedirectToPage();
    }

    public IActionResult OnPostUnlockDating(long uid)
    {
        // DatingInfo 不是设计表的镜像：客户端按 DatingCostumeTable.EpisodeGroupId
        // 查找玩家进度，而旧逻辑只更新已有行，导致新玩家/缺行的约会（例如格鲁）不会出现。
        var episodeGroups = new List<(int GroupId, int LastEpisodeId)>();
        using (var connection = new SQLiteConnection($"Data Source={DesignDbHelper.GetCommonDbPath()};Version=3;Read Only=True;"))
        {
            connection.Open();
            using var command = new SQLiteCommand(
                "SELECT groupId, MAX(id) FROM DatingEpisodeTable GROUP BY groupId", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                episodeGroups.Add((Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1])));
            }
        }

        var rows = _db.Queryable<DatingInfoDao>().Where(x => x.Uid == uid).ToList();
        var byGroup = rows.ToDictionary(x => x.GroupId);
        var inserted = 0;
        foreach (var (groupId, lastEpisodeId) in episodeGroups)
        {
            if (!byGroup.TryGetValue(groupId, out var row))
            {
                row = new DatingInfoDao
                {
                    Uid = uid,
                    GroupId = groupId,
                    DatingPoint = 9999,
                    LastClearId = lastEpisodeId,
                    LastMessageGroupId = 0,
                    LastMessageId = 0,
                    LastMessageUpdateTime = 0
                };
                _db.Insertable(row).ExecuteCommand();
                inserted++;
                continue;
            }

            row.DatingPoint = Math.Max(row.DatingPoint, 9999);
            row.LastClearId = Math.Max(row.LastClearId, lastEpisodeId);
            _db.Updateable(row).ExecuteCommand();
        }

        TempData["CheatMessage"] = $"已解锁 {episodeGroups.Count} 个约会组，更新 {rows.Count - inserted} 条，新增 {inserted} 条；进度已设置到各组最后一话。";
        return RedirectToPage();
    }

    public IActionResult OnPostAddAllCostumes(long uid)
    {
        var chars = _db.Queryable<CharInfoDao>().Where(x => x.Uid == uid).ToList();
        var existing = _db.Queryable<CostumeInfoDao>().Where(x => x.Uid == uid).Select(x => x.Id).ToList();
        var rows = DesignDbHelper.LoadFromCommon("CostumeTable", CostumeTable.Parser)
            .Where(x => x.Id != 0 && !existing.Contains(x.Id) && InventoryItemResolver.Resolve((int)ItemType.Costume, x.Id).Category == InventoryItemCategory.PlayerCostume).ToList();
        foreach (var costume in rows)
        {
            var owner = chars.FirstOrDefault(x => CharManager.GetCharData(x.Id)?.UniqueCharId == costume.UseUniqueCharId);
            var baseChar = CharManager.GetBaseCharData(costume.UseUniqueCharId);
            if (baseChar == null) continue;

            var costumeInfo = new CostumeInfoDao
            {
                Uid = uid,
                Id = costume.Id,
                Level = 1,
                // 已有角色的新增服装不是当前装备服装；客户端通过 CharInfo.UseCostume 确认当前服装。
                UseChar = owner?.UseCostume > 0 ? null : owner?.InvenIndex,
                SortId = 0,
                UseMyRoomCount = 0
            };
            costumeInfo.InvenIndex = _db.Insertable(costumeInfo).ExecuteReturnIdentity();

            if (owner == null)
            {
                var newChar = new CharInfoDao
                {
                    Uid = uid,
                    Id = baseChar.Id,
                    Hp = (long)Math.Round(baseChar.HealthValue),
                    Level = 1,
                    SolidarityReward = 1,
                    TalentLevel = 1,
                    ExpiryTime = -32400000L,
                    UseCostume = costumeInfo.InvenIndex,
                    ConnectPotentialCostume = costume.SkillGroupId,
                    UniqueCharId = baseChar.UniqueCharId
                };
                newChar.InvenIndex = _db.Insertable(newChar).ExecuteReturnIdentity();
                costumeInfo.UseChar = newChar.InvenIndex;
                _db.Updateable(costumeInfo).ExecuteCommand();
                chars.Add(newChar);
            }
            else if (owner.UseCostume == 0)
            {
                owner.UseCostume = costumeInfo.InvenIndex;
                costumeInfo.UseChar = owner.InvenIndex;
                _db.Updateable(owner).ExecuteCommand();
                _db.Updateable(costumeInfo).ExecuteCommand();
            }
        }
        TempData["CheatMessage"] = $"已添加 {rows.Count} 件普通服装。";
        return RedirectToPage();
    }

    public IActionResult OnPostUnlockSkins(long uid)
    {
        var count = 0;
        foreach (var raw in DesignDbHelper.LoadRawFromCommon("PrestigeSkinTable"))
        {
            var skin = ParseSkin(raw.Id, raw.ProtoBuf);
            if (skin == null || CostumeManager.GetCostume(skin.Value.CostumeId) == null) continue;
            if (!_db.Queryable<PrestigeSkinInfoDao>().Any(x => x.Uid == uid && x.CostumeId == skin.Value.CostumeId && x.CostumeDesignId == skin.Value.DesignId))
            { _db.Insertable(new PrestigeSkinInfoDao { Uid = uid, CostumeId = skin.Value.CostumeId, CostumeDesignId = skin.Value.DesignId, IsSet = 0 }).ExecuteCommand(); count++; }
        }
        TempData["CheatMessage"] = $"已解锁 {count} 个真实 PrestigeSkinTable 皮肤。";
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostUnlockFeatures(long uid)
    {
        var result = await _contentUnlockService.UnlockIndependentContentAsync(uid);
        TempData["CheatMessage"] = $"已开放独立玩法：新增 {result.Added}，已有 {result.Existing}，跳过 {result.Skipped}，无效 {result.Invalid}。";
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostActivateMonsterHunt(int monsterHuntId, int season, int durationDays = 30)
    {
        var result = await _scheduleAdminService.ActivateMonsterHuntAsync(monsterHuntId, season, durationDays);
        TempData["CheatMessage"] = result.Message;
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostActivateEvents(int durationDays = 30)
    {
        var result = await _scheduleAdminService.ActivateConfiguredEventsAsync(durationDays);
        TempData["CheatMessage"] = result.Message;
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostConfigureEvent(string eventKey, int durationDays = 30)
    {
        var parts = (eventKey ?? string.Empty).Split('|');
        if (parts.Length != 3 || !int.TryParse(parts[0], out var eventType) || !int.TryParse(parts[1], out var eventId) || !int.TryParse(parts[2], out var eventSubId))
        {
            TempData["CheatMessage"] = "请选择有效的活动。";
            return RedirectToPage();
        }
        var result = await _scheduleAdminService.ConfigureEventAsync(eventType, eventId, eventSubId, durationDays);
        TempData["CheatMessage"] = result.Message;
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostActivateGacha(int gachaGroupRowId, int durationDays = 30)
    {
        var result = await _scheduleAdminService.ActivateGachaAsync(gachaGroupRowId, durationDays);
        TempData["CheatMessage"] = result.Message;
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostDisableGacha(int gachaGroupRowId)
    {
        var result = await _scheduleAdminService.DisableGachaAsync(gachaGroupRowId);
        TempData["CheatMessage"] = result.Message;
        return RedirectToPage();
    }

    public IActionResult OnPostClearBrokenFeatureTickets(long uid)
    {
        // 仅清理旧 Cheat 写入的特征记录，不触碰正常 ItemInfo：
        // Type=19、KeepFlag=1、TimeValue=0、ExpiryTime=-32400000。
        var rows = _db.Queryable<ItemInfoDao>()
            .Where(x => x.Uid == uid && x.Type == (int)ItemType.ContentTicket
                && x.KeepFlag == 1 && x.TimeValue == 0 && x.ExpiryTime == -32400000L)
            .ToList();
        if (rows.Count > 0)
            _db.Deleteable(rows).ExecuteCommand();

        TempData["CheatMessage"] = $"已清理 {rows.Count} 条旧格式功能凭证，请重新登录测试。";
        return RedirectToPage();
    }

    private void LoadPlayers()
    {
        Message = TempData["CheatMessage"] as string;
        Players = _db.Queryable<UserInfoDao>().OrderBy(x => x.OwnerIndex).ToList();
    }

    private void LoadScheduleOptions()
    {
        MonsterHunts = DesignDbHelper.LoadFromCommon("MonsterHuntTable", MonsterHuntTable.Parser)
            .Where(x => x.Id > 0)
            .OrderBy(x => x.Id)
            .Select(x =>
            {
                var name = x.BossTipLocalTextId != 0 ? NameTextManager.GetText(x.BossTipLocalTextId) : "";
                if (name.StartsWith("#") && x.BossTipLocalTextId != 0) name = LocalTextManager.GetText(x.BossTipLocalTextId);
                if (name.StartsWith("#") && x.DescTextId != 0) name = LocalTextManager.GetText(x.DescTextId);
                if (string.IsNullOrWhiteSpace(name) || name.StartsWith("#")) name = $"魔物 {x.MonsterId}";
                return new MonsterHuntOption(x.Id, x.MonsterId, x.PackId, name);
            })
            .ToList();

        var configuredSubIds = _db.Queryable<EventScheduleConfigDao>().ToList()
            .GroupBy(x => (x.EventType, x.EventId))
            .ToDictionary(x => x.Key, x => x.Select(v => v.EventSubId).Distinct().ToList());
        Events = DesignDbHelper.LoadFromCommon("EventTable", EventTable.Parser)
            .Where(x => x.EventId > 0)
            .GroupBy(x => (x.EventType, x.EventId))
            .SelectMany(group =>
            {
                var subIds = configuredSubIds.TryGetValue(group.Key, out var ids) && ids.Count > 0 ? ids : new List<int> { 0 };
                var design = group.OrderBy(x => x.SortId).First();
                var name = NameTextManager.GetText(design.EventNameTextId);
                if (name.StartsWith("#") && design.EventNameTextId != 0)
                    name = LocalTextManager.GetText(design.EventNameTextId);
                if (string.IsNullOrWhiteSpace(name) || name.StartsWith("#"))
                    name = string.IsNullOrWhiteSpace(design.BannerResouceName)
                        ? $"活动类型 {group.Key.EventType}"
                        : design.BannerResouceName;
                return subIds.Select(subId => new EventOption(group.Key.EventType, group.Key.EventId, subId,
                    $"{name} / 类型 {group.Key.EventType} / ID {group.Key.EventId} / 子活动 {subId}"));
            })
            .OrderBy(x => x.Name)
            .ToList();

        var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        var configs = _db.Queryable<GachaScheduleConfigDao>().ToList()
            .GroupBy(x => x.GachaGroupRowId).ToDictionary(x => x.Key, x => x.OrderByDescending(v => v.UpdatedAt).First());
        Gachas = GachaDesignManager.LoadGroups()
            .Where(x => x.Type is 1 or 2 && x.SortId > 0 && !string.IsNullOrWhiteSpace(x.BannerImage))
            .Select(x =>
            {
                configs.TryGetValue(x.RowId, out var config);
                var enabled = x.ScheduleType == 0 || (config?.Enabled == 1 && config.StartTime <= now && now < config.EndTime);
                var name = NameTextManager.GetText(x.NameTextId);
                if (name.StartsWith("#") && x.NameTextId != 0) name = LocalTextManager.GetText(x.NameTextId);
                if (string.IsNullOrWhiteSpace(name) || name.StartsWith("#")) name = "未命名卡池";
                return new GachaOption(x.RowId, name, x.Type, x.SortId, enabled, x.ScheduleType == 0);
            })
            .OrderBy(x => x.Type).ThenBy(x => x.SortId).ToList();
    }

    private static (int CostumeId, int DesignId)? ParseSkin(long id, byte[] data)
    {
        var costume = 0; var design = (int)id;
        for (var i = 0; i < data.Length;)
        {
            var tag = ReadVarint(data, ref i); var field = (int)(tag >> 3); var wire = (int)(tag & 7);
            if (wire == 0) { var value = (int)ReadVarint(data, ref i); if (field == 1) costume = value; else if (field == 4 && value != 0) design = value; }
            else if (wire == 2) i += (int)ReadVarint(data, ref i);
            else if (wire == 1) i += 8; else if (wire == 5) i += 4; else return null;
        }
        return costume == 0 ? null : (costume, design);
    }
    private static ulong ReadVarint(byte[] data, ref int offset) { ulong value = 0; var shift = 0; while (offset < data.Length) { var b = data[offset++]; value |= (ulong)(b & 127) << shift; if ((b & 128) == 0) return value; shift += 7; } throw new InvalidOperationException("Invalid PrestigeSkinTable protobuf"); }
}
