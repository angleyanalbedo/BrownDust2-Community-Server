using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;

namespace Bd2.Server.Common.Managers;

public static class LocalTextManager
{
    private static readonly Dictionary<int, LocalTextTable> Texts = DesignDbHelper.LoadFromCommon("LocalTextTable", LocalTextTable.Parser)
        .GroupBy(x => x.Id).ToDictionary(x => x.Key, x => x.First());

    public static string GetText(int id, string language = "zh-CN")
    {
        if (!Texts.TryGetValue(id, out var text)) return $"#{id}";
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
}
