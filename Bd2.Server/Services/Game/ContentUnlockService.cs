using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Enums;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;
using Bd2.Server.DAO.Game;
using Bd2.Server.iServices.Game;
using Microsoft.Extensions.Logging;
using SqlSugar;

namespace Bd2.Server.Services.Game;

/// <summary>根据 ContentOpenTable 写入真实的内容开放凭证，不写入主线凭证。</summary>
public sealed class ContentUnlockService : IContentUnlockService
{
    private readonly ISqlSugarClient _db;
    private readonly ILogger<ContentUnlockService> _logger;

    private static readonly HashSet<Define_ContentOpenType> IndependentContent = new()
    {
        Define_ContentOpenType.ContentUnlockHunting,
        Define_ContentOpenType.ContentUnlockNoneUse,
        Define_ContentOpenType.ContentUnlockGacha,
        Define_ContentOpenType.ContentUnlockUiEvent,
        Define_ContentOpenType.ContentUnlockUiShop,
        Define_ContentOpenType.ContentUnlockUiPass,
        Define_ContentOpenType.ContentUnlockUiMission,
        Define_ContentOpenType.ContentUnlockUiMail,
        Define_ContentOpenType.ContentUnlockUiPictorialBook,
        Define_ContentOpenType.ContentUnlockMonsterHunt,
        Define_ContentOpenType.ContentUnlockAchievement,
        Define_ContentOpenType.ContentUnlockHuntDispatch,
        Define_ContentOpenType.ContentUnlockFriend,
        Define_ContentOpenType.ContentUnlockMyRoom,
        Define_ContentOpenType.ContentUnlockGuild,
        Define_ContentOpenType.ContentUnlockEvilCastleRogueLike
    };

    public ContentUnlockService(ISqlSugarClient db, ILogger<ContentUnlockService> logger)
    {
        _db = db;
        _logger = logger;
    }

    public async Task<ContentUnlockResult> UnlockIndependentContentAsync(long uid)
    {
        var allRows = DesignDbHelper.LoadFromCommon("ContentOpenTable", ContentOpenTable.Parser);
        var rows = allRows
            .Where(x => x.TicketId > 0 && IndependentContent.Contains((Define_ContentOpenType)x.GroupId))
            .GroupBy(x => x.TicketId).Select(x => x.First()).ToList();
        var added = 0;
        var existing = 0;
        var invalid = 0;

        foreach (var open in rows)
        {
            if (open.TicketId <= 0) { invalid++; continue; }
            var hasSpecial = await _db.Queryable<ItemSpecialInfoDao>().AnyAsync(x =>
                x.Uid == uid && x.Id == open.TicketId && x.Type == (int)ItemType.ContentTicket);
            var hasNormal = await _db.Queryable<ItemInfoDao>().AnyAsync(x =>
                x.Uid == uid && x.Id == open.TicketId && x.Type == (int)ItemType.ContentTicket);
            if (hasSpecial || hasNormal) { existing++; continue; }

            await _db.Insertable(new ItemSpecialInfoDao
            {
                Uid = uid, Id = open.TicketId, Type = (int)ItemType.ContentTicket,
                Count = 1, ExpiryTime = 0
            }).ExecuteCommandAsync();
            added++;
        }

        var skipped = allRows
            .Count(x => x.TicketId > 0 && !IndependentContent.Contains((Define_ContentOpenType)x.GroupId));
        _logger.LogInformation("Content unlock: uid={Uid}, added={Added}, existing={Existing}, skipped={Skipped}, invalid={Invalid}",
            uid, added, existing, skipped, invalid);
        return new ContentUnlockResult(added, existing, skipped, invalid);
    }
}
