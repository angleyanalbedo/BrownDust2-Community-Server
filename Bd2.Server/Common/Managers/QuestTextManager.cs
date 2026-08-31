using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;

namespace Bd2.Server.Common.Managers;

public static class QuestTextManager
{
    private static readonly Dictionary<int, Dictionary<int, QuestTextTable>> TextsByPack = new();

    public static string GetText(int packId, int textId, string language = "zh-CN")
    {
        if (!TextsByPack.TryGetValue(packId, out var texts))
        {
            try { texts = DesignDbHelper.LoadFromPack(packId, "QuestTextTable", QuestTextTable.Parser).GroupBy(x => x.Id).ToDictionary(x => x.Key, x => x.First()); }
            catch (Exception ex) { Console.WriteLine($"[QuestTextManager] pack {packId}: {ex.Message}"); texts = new(); }
            TextsByPack[packId] = texts;
        }
        texts.TryGetValue(textId, out var text);
        if (text == null) return textId == 0 ? "未命名任务" : $"#{textId}";
        var value = language?.ToLowerInvariant() switch
        {
            "ko" or "kr" or "ko-kr" => text.Text,
            "en" or "en-us" or "en-gb" => text.TextEn,
            "ja" or "jp" or "ja-jp" => text.TextJp,
            "zh-tw" or "tw" => text.TextTw,
            _ => text.TextCn
        };
        return string.IsNullOrWhiteSpace(value) ? text.Text : value;
    }

    public static string GetQuestName(int packId, QuestTable1 quest, string language = "zh-CN") =>
        GetText(packId, quest.QuestNameQuestTextId, language);
}
