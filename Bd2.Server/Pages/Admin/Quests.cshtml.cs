using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Bd2.Server.Common.Managers;
using Bd2.Server.DAO.Game;
using Bd2.Server.iServices.Game;
using SqlSugar;

namespace Bd2.Server.Pages.Admin;

[Authorize(AuthenticationSchemes = "AdminCookie")]
public class QuestsModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
    private readonly ISqlSugarClient _db;
    private readonly IGameQuestService _questService;

    public QuestsModel(ISqlSugarClient db, IGameQuestService questService) { _db = db; _questService = questService; }

    public string Uid { get; set; } = "";
    public List<QuestInfoDao> QuestList { get; set; } = new();
    public List<PackInfo> PackQuests { get; set; } = new();
    public string? Message { get; set; }
    public bool IsSuccess { get; set; }

    public class PackInfo
    {
        public int PackId { get; set; }
        public int CurrentQuestId { get; set; }
        public bool IsComplete { get; set; }
        public List<int> ClearedQuestIds { get; set; } = new();
        public string QuestChain { get; set; } = "";
        public List<QuestDef> Definitions { get; set; } = new();
    }

    public class QuestDef
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int ConditionType { get; set; }
        public int ConditionCount { get; set; }
        public int NextQuestId { get; set; }
    }

    public async Task OnGetAsync(string? uid)
    {
        Uid = uid ?? "";
        if (string.IsNullOrWhiteSpace(Uid)) return;

        var user = await _db.Queryable<UserInfoDao>().Where(x => x.UserId == Uid).FirstAsync();
        if (user == null) return;

        QuestList = await _db.Queryable<QuestInfoDao>()
            .Where(x => x.Uid == user.OwnerIndex)
            .ToListAsync();

        BuildPackInfo();
    }

    public async Task<IActionResult> OnPostCompleteQuestAsync(string uid, int packId)
    {
        Uid = uid;
        var user = await _db.Queryable<UserInfoDao>().Where(x => x.UserId == Uid).FirstAsync();
        if (user == null) { Message = "玩家不存在"; IsSuccess = false; return Page(); }

        var quest = await _db.Queryable<QuestInfoDao>()
            .Where(x => x.Uid == user.OwnerIndex && x.PackId == packId)
            .FirstAsync();

        if (quest == null)
        {
            Message = "该包无任务数据"; IsSuccess = false; return Page();
        }

        var clearedIds = string.IsNullOrEmpty(quest.QuestClear)
            ? new List<int>()
            : JsonConvert.DeserializeObject<List<int>>(quest.QuestClear) ?? new List<int>();

        if (!clearedIds.Contains(quest.QuestId))
        {
            clearedIds.Add(quest.QuestId);
        }

        var questTable = QuestManager.GetQuestTable(packId, quest.QuestId);
        if (questTable != null && questTable.NextQuestId != 0)
        {
            quest.QuestId = questTable.NextQuestId;
        }
        else
        {
            quest.IsPackComplete = 1;
        }

        quest.QuestClear = JsonConvert.SerializeObject(clearedIds);
        await _db.Updateable(quest).ExecuteCommandAsync();

        Message = $"Pack {packId} 任务 {clearedIds.Last()} 已完成"; IsSuccess = true;

        QuestList = await _db.Queryable<QuestInfoDao>().Where(x => x.Uid == user.OwnerIndex).ToListAsync();
        BuildPackInfo();
        return Page();
    }

    public async Task<IActionResult> OnPostCompleteSpecificQuestAsync(string uid, int packId, int questId)
    {
        Uid = uid;
        var user = await _db.Queryable<UserInfoDao>().Where(x => x.UserId == Uid).FirstAsync();
        var quest = user == null ? null : await _db.Queryable<QuestInfoDao>().Where(x => x.Uid == user.OwnerIndex && x.PackId == packId).FirstAsync();
        if (quest == null) { Message = "该包无任务数据"; IsSuccess = false; return Page(); }
        var cleared = string.IsNullOrEmpty(quest.QuestClear) ? new List<int>() : JsonConvert.DeserializeObject<List<int>>(quest.QuestClear) ?? new();
        if (!cleared.Contains(questId)) cleared.Add(questId);
        if (quest.QuestId == questId)
        {
            var table = QuestManager.GetQuestTable(packId, questId);
            if (table?.NextQuestId != 0) quest.QuestId = table!.NextQuestId;
            else quest.IsPackComplete = 1;
        }
        quest.QuestClear = JsonConvert.SerializeObject(cleared);
        await _db.Updateable(quest).ExecuteCommandAsync();
        Message = $"任务 {questId} 已完成"; IsSuccess = true;
        QuestList = await _db.Queryable<QuestInfoDao>().Where(x => x.Uid == user!.OwnerIndex).ToListAsync();
        BuildPackInfo();
        return Page();
    }

    public async Task<IActionResult> OnPostResetPackAsync(string uid, int packId)
    {
        Uid = uid;
        var user = await _db.Queryable<UserInfoDao>().Where(x => x.UserId == Uid).FirstAsync();
        if (user == null) { Message = "玩家不存在"; IsSuccess = false; return Page(); }

        await _db.Deleteable<QuestInfoDao>()
            .Where(x => x.Uid == user.OwnerIndex && x.PackId == packId)
            .ExecuteCommandAsync();

        Message = $"Pack {packId} 已重置"; IsSuccess = true;

        QuestList = await _db.Queryable<QuestInfoDao>().Where(x => x.Uid == user.OwnerIndex).ToListAsync();
        BuildPackInfo();
        return Page();
    }

    public async Task<IActionResult> OnPostCompletePackAsync(string uid, int packId)
    {
        Uid = uid;
        var user = await _db.Queryable<UserInfoDao>().Where(x => x.UserId == Uid).FirstAsync();
        if (user == null) { Message = "玩家不存在"; IsSuccess = false; return Page(); }
        await _questService.FastCompletePack(user.OwnerIndex, packId);
        // QuestClear normally creates the next main-story Pack in its response.
        // The admin page has no response round-trip, so persist that initial
        // record as well; otherwise the client cannot see the newly unlocked
        // Pack/features after the next login.
        if (packId < 14 && await _db.Queryable<QuestInfoDao>().AnyAsync(x => x.Uid == user!.OwnerIndex && x.PackId == packId + 1) == false)
        {
            await _db.Insertable(new QuestInfoDao
            {
                Uid = user!.OwnerIndex,
                PackId = packId + 1,
                QuestId = 1,
                QuestClear = "[]",
                IsPackComplete = 0
            }).ExecuteCommandAsync();
        }
        Message = $"Pack {packId} 已完成全部任务"; IsSuccess = true;
        QuestList = await _db.Queryable<QuestInfoDao>().Where(x => x.Uid == user!.OwnerIndex).ToListAsync();
        BuildPackInfo();
        return Page();
    }

    private void BuildPackInfo()
    {
        PackQuests.Clear();
        var packIds = QuestManager.GetAllPackIds();

        foreach (var packId in packIds)
        {
            var quest = QuestList.FirstOrDefault(x => x.PackId == packId);
            var clearedIds = quest != null && !string.IsNullOrEmpty(quest.QuestClear)
                ? (JsonConvert.DeserializeObject<List<int>>(quest.QuestClear) ?? new List<int>())
                : new List<int>();

            var definitions = new List<QuestDef>();
            var chain = new List<int>();
            try
            {
                int startId = 1;
                if (quest != null && quest.QuestId > 0) startId = quest.QuestId;

                for (int qid = 1; qid <= 99; qid++)
                {
                    var qt = QuestManager.GetQuestTable(packId, qid);
                    if (qt == null) break;
                    definitions.Add(new QuestDef
                    {
                        Id = qt.Id,
                        Name = QuestTextManager.GetQuestName(packId, qt),
                        ConditionType = qt.ConditionType,
                        ConditionCount = qt.ConditionCount,
                        NextQuestId = qt.NextQuestId
                    });
                    chain.Add(qt.Id);
                    if (qt.NextQuestId == 0) break;
                }
            }
            catch { /* pack might not exist */ }

            PackQuests.Add(new PackInfo
            {
                PackId = packId,
                CurrentQuestId = quest?.QuestId ?? 0,
                IsComplete = quest?.IsPackComplete == 1,
                ClearedQuestIds = clearedIds,
                QuestChain = chain.Any() ? string.Join(" → ", chain) : "无数据",
                Definitions = definitions
            });
        }

        // The game presents the active main-story Pack, not every historical
        // Pack at once. Show the first unfinished Pack; if all are complete,
        // keep the latest one visible for inspection.
        var active = PackQuests.FirstOrDefault(x => QuestList.Any(q => q.PackId == x.PackId) && !x.IsComplete)
            ?? PackQuests.LastOrDefault(x => QuestList.Any(q => q.PackId == x.PackId));
        PackQuests = active == null ? new List<PackInfo>() : new List<PackInfo> { active };
    }
}
