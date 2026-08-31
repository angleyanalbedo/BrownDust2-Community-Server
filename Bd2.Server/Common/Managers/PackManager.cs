using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;

namespace Bd2.Server.Common.Managers;

public static class PackManager
{
    private static readonly Dictionary<int, PackTable> Packs;

    static PackManager()
    {
        Packs = new();
        foreach (var row in DesignDbHelper.LoadRawFromCommon("PackTable"))
        {
            try
            {
                var pack = PackTable.Parser.ParseFrom(row.ProtoBuf);
                Packs[pack.Id != 0 ? pack.Id : (int)row.Id] = pack;
            }
            catch (Exception ex) { Console.WriteLine($"[PackManager] skipped PackTable row {row.Id}: {ex.Message}"); }
        }
    }

    public static string GetName(int packId, string language = "zh-CN")
    {
        if (!Packs.TryGetValue(packId, out var pack)) return $"Pack {packId}";
        var textId = pack.PackNameTextId != 0 ? pack.PackNameTextId : pack.PackDescNameTextId;
        var name = textId == 0 ? "" : NameTextManager.GetText(textId, language);
        if (name.StartsWith("#") && textId != 0) name = LocalTextManager.GetText(textId, language);
        return string.IsNullOrWhiteSpace(name) || name.StartsWith("#") ? $"Pack {packId}" : name;
    }
}
