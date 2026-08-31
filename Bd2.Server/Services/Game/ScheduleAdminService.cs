using System;
using System.Linq;
using System.Threading.Tasks;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.DAO.Game;
using Bd2.Server.iServices.Game;
using Microsoft.Extensions.Logging;
using SqlSugar;

namespace Bd2.Server.Services.Game;

/// <summary>
/// 修改运行中的活动周期。这里只修改服务器保存的 Schedule 配置，
/// 不把活动设计表的 ID 当作运行时活动，也不改变主线任务。
/// </summary>
public sealed class ScheduleAdminService : IScheduleAdminService
{
    private readonly ISqlSugarClient _db;
    private readonly ILogger<ScheduleAdminService> _logger;

    public ScheduleAdminService(ISqlSugarClient db, ILogger<ScheduleAdminService> logger)
    {
        _db = db;
        _logger = logger;
    }

    public async Task<ScheduleAdminResult> ActivateMonsterHuntAsync(int monsterHuntId, int season, int durationDays)
    {
        if (monsterHuntId <= 0 || season <= 0)
            return new(false, 0, "魔物狩猎 ID 和赛季必须是正数。");
        if (durationDays is < 1 or > 365)
            return new(false, 0, "持续天数必须在 1 到 365 天之间。");

        var monster = DesignDbHelper.LoadFromCommon("MonsterHuntTable", MonsterHuntTable.Parser)
            .FirstOrDefault(x => x.Id == monsterHuntId);
        if (monster == null)
            return new(false, 0, $"MonsterHuntTable 中不存在 ID={monsterHuntId}，未修改数据库。");

        var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        var end = now + durationDays * 24L * 60 * 60 * 1000;
        var config = await _db.Queryable<MonsterHuntScheduleConfigDao>().FirstAsync();
        if (config == null)
        {
            config = new MonsterHuntScheduleConfigDao
            {
                Season = season,
                SeasonStartTime = now,
                SeasonEndTime = end,
                MonsterHuntId = monsterHuntId,
                InfoOpenDay = 0,
                CalculateEndDate = end,
                StartRegularSeason = 1
            };
            await _db.Insertable(config).ExecuteCommandAsync();
        }
        else
        {
            config.Season = season;
            config.SeasonStartTime = now;
            config.SeasonEndTime = end;
            config.MonsterHuntId = monsterHuntId;
            config.InfoOpenDay = 0;
            config.CalculateEndDate = end;
            config.StartRegularSeason = 1;
            await _db.Updateable(config).ExecuteCommandAsync();
        }

        // 当前赛季切换时，保留玩家历史成绩，不伪造或删除玩家战绩。
        _logger.LogInformation("Monster hunt schedule activated: id={MonsterHuntId}, season={Season}, end={End}", monsterHuntId, season, end);
        return new(true, 1, $"魔物狩猎 {monsterHuntId} 已切换到第 {season} 赛季，持续 {durationDays} 天。");
    }

    public async Task<ScheduleAdminResult> ActivateConfiguredEventsAsync(int durationDays)
    {
        if (durationDays is < 1 or > 365)
            return new(false, 0, "持续天数必须在 1 到 365 天之间。");

        var rows = await _db.Queryable<EventScheduleConfigDao>().ToListAsync();
        if (rows.Count == 0)
            return new(false, 0, "EventScheduleConfig 当前没有活动记录；未凭空创建活动。");

        var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        var end = now + durationDays * 24L * 60 * 60 * 1000;
        foreach (var row in rows)
        {
            row.StartDate = now;
            row.EndDate = end;
        }
        await _db.Updateable(rows).ExecuteCommandAsync();
        _logger.LogInformation("Configured event schedules activated: count={Count}, end={End}", rows.Count, end);
        return new(true, rows.Count, $"已将 {rows.Count} 条已配置活动延长为当前开放，持续 {durationDays} 天。");
    }

    public async Task<ScheduleAdminResult> ConfigureEventAsync(int eventType, int eventId, int eventSubId, int durationDays)
    {
        if (eventType < 0 || eventId <= 0 || eventSubId < 0 || durationDays is < 1 or > 365)
            return new(false, 0, "活动类型、活动 ID、子活动 ID 或持续天数无效。");

        var design = DesignDbHelper.LoadFromCommon("EventTable", EventTable.Parser)
            .FirstOrDefault(x => x.EventType == eventType && x.EventId == eventId);
        if (design == null)
            return new(false, 0, $"EventTable 中不存在 EventType={eventType}, EventId={eventId} 的设计记录。");

        var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        var end = now + durationDays * 24L * 60 * 60 * 1000;
        var row = await _db.Queryable<EventScheduleConfigDao>()
            .FirstAsync(x => x.EventType == eventType && x.EventId == eventId && x.EventSubId == eventSubId);
        if (row == null)
        {
            row = new EventScheduleConfigDao
            {
                Id = (await _db.Queryable<EventScheduleConfigDao>().MaxAsync(x => (int?)x.Id) ?? 0) + 1,
                EventType = eventType,
                EventId = eventId,
                EventSubId = eventSubId,
                StartDate = now,
                EndDate = end
            };
            await _db.Insertable(row).ExecuteCommandAsync();
            return new(true, 1, $"已新增活动配置 EventType={eventType}, EventId={eventId}, EventSubId={eventSubId}。");
        }

        row.StartDate = now;
        row.EndDate = end;
        await _db.Updateable(row).ExecuteCommandAsync();
        return new(true, 1, $"已更新活动配置 EventType={eventType}, EventId={eventId}, EventSubId={eventSubId}。");
    }

    public async Task<ScheduleAdminResult> ActivateGachaAsync(int gachaGroupRowId, int durationDays)
    {
        if (gachaGroupRowId <= 0 || durationDays is < 1 or > 365)
            return new(false, 0, "卡池和开放天数无效。");

		var group = GachaDesignManager.LoadGroups().FirstOrDefault(x => x.RowId == gachaGroupRowId);
		if (group == null) return new(false, 0, $"GachaGroupTable 中不存在行 ID={gachaGroupRowId}。");
		var gachaIds = GachaDesignManager.LoadGachaIds();
		if (group.Type is not (1 or 2) || group.SortId <= 0 || string.IsNullOrWhiteSpace(group.BannerImage)
			|| (!gachaIds.Contains(group.OneTimeGachaId) && !gachaIds.Contains(group.TenTimeGachaId)))
            return new(false, 0, "该卡池缺少有效的普通抽卡配置，不能开放。");

        var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        var config = await _db.Queryable<GachaScheduleConfigDao>().FirstAsync(x => x.GachaGroupRowId == gachaGroupRowId);
        if (config == null)
        {
            config = new GachaScheduleConfigDao { GachaGroupRowId = gachaGroupRowId };
            config.Id = await _db.Insertable(config).ExecuteReturnIdentityAsync();
        }
        config.Enabled = 1;
        config.StartTime = now;
        config.EndTime = now + durationDays * 24L * 60 * 60 * 1000;
        config.UpdatedAt = now;
        await _db.Updateable(config).ExecuteCommandAsync();
        return new(true, 1, $"卡池 {gachaGroupRowId} 已开放 {durationDays} 天。");
    }

    public async Task<ScheduleAdminResult> DisableGachaAsync(int gachaGroupRowId)
    {
        var config = await _db.Queryable<GachaScheduleConfigDao>().FirstAsync(x => x.GachaGroupRowId == gachaGroupRowId);
        if (config == null) return new(false, 0, "该卡池没有运行时开放配置。");
        config.Enabled = 0;
        config.UpdatedAt = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        await _db.Updateable(config).ExecuteCommandAsync();
        return new(true, 1, $"卡池 {gachaGroupRowId} 已关闭。");
    }
}
