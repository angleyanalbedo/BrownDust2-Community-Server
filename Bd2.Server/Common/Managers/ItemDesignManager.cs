using System;
using System.Collections.Generic;
using System.Linq;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.Common.Proto.Net;

namespace Bd2.Server.Common.Managers;

/// <summary>
/// Resolves an inventory item's (Type, Id) to its design-table name TextId.
/// ItemInfo.Id is a business/design id; it is not generally a NameTextTable id.
/// </summary>
public static class ItemDesignManager
{
    private static readonly Dictionary<(int Type, int Id), int> NameTextIds = Load();

    public static string GetName(ItemInfoType type, int id, string language = "zh-CN")
    {
        return GetName((int)type, id, language);
    }

    public static string GetName(int type, int id, string language = "zh-CN")
    {
        return NameTextIds.TryGetValue((type, id), out var textId)
            ? NameTextManager.GetText(textId, language)
            : $"ID:{id}";
    }

    public static IEnumerable<(int Type, int Id, string Name)> Search(string query, int limit, string language = "zh-CN", int? type = null)
    {
        return NameTextIds
            .Where(x => !type.HasValue || x.Key.Type == type.Value)
            .Select(x => (x.Key.Type, x.Key.Id, Name: NameTextManager.GetText(x.Value, language)))
            .Where(x => x.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
            .Take(Math.Clamp(limit, 1, 100));
    }

    private static Dictionary<(int Type, int Id), int> Load()
    {
        var result = new Dictionary<(int, int), int>();
        Add(result, (int)Define_ElementType.TypeResource, DesignDbHelper.LoadFromCommon("ResourceTable", ResourceTable.Parser), x => (x.Id, x.ItemNameTextId));
        Add(result, (int)Define_ElementType.TypeFood, DesignDbHelper.LoadFromCommon("FoodTable", FoodTable.Parser), x => (x.Id, x.ItemNameTextId));
        Add(result, (int)Define_ElementType.TypeQuest, DesignDbHelper.LoadFromCommon("QuestItemTable", QuestItemTable.Parser), x => (x.Id, x.ItemNameTextId));
        Add(result, (int)Define_ElementType.TypeUseItem, DesignDbHelper.LoadFromCommon("UseItemTable", UseItemTable.Parser), x => (x.Id, x.ItemNameTextId));
        Add(result, (int)Define_ElementType.TypeCollection, DesignDbHelper.LoadFromCommon("CollectionTable", CollectionTable.Parser), x => (x.Id, x.ItemNameTextId));
        Add(result, (int)Define_ElementType.TypeInstantUseItem, DesignDbHelper.LoadFromCommon("InstantUseItemTable", InstantUseItemTable.Parser), x => (x.Id, x.ItemNameTextId));
        Add(result, (int)Define_ElementType.TypeCash, DesignDbHelper.LoadFromCommon("CurrencyTable", CurrencyTable.Parser), x => (x.Id, x.ItemNameTextId));
        Add(result, (int)Define_ElementType.TypeRandomBox, DesignDbHelper.LoadFromCommon("RandomBoxTable", RandomBoxTable.Parser), x => (x.Id, x.ItemNameRandomBoxTextId));
        return result;
    }

    private static void Add<T>(Dictionary<(int, int), int> target, int type, IEnumerable<T> rows, Func<T, (int Id, int TextId)> selector)
    {
        foreach (var row in rows)
        {
            var value = selector(row);
            if (value.TextId != 0)
                target[(type, value.Id)] = value.TextId;
        }
    }

}

public enum ItemInfoType
{
    Resource = (int)Define_ElementType.TypeResource,
    Food = (int)Define_ElementType.TypeFood,
    Quest = (int)Define_ElementType.TypeQuest,
    UseItem = (int)Define_ElementType.TypeUseItem,
    Collection = (int)Define_ElementType.TypeCollection,
    InstantUseItem = (int)Define_ElementType.TypeInstantUseItem,
    Currency = (int)Define_ElementType.TypeCash,
    RandomBox = (int)Define_ElementType.TypeRandomBox
}
