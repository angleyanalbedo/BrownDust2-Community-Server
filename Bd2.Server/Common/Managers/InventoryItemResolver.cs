using System;
using System.Linq;
using Bd2.Server.Common.Enums;

namespace Bd2.Server.Common.Managers;

public enum InventoryItemCategory
{
    Unknown,
    PlayerCostume,
    BossCostume,
    Equipment,
    StackableItem,
    ContentTicket,
    LobbyInteractionTicket,
    Currency
}

public sealed record InventoryItemResolution(
    bool IsValid,
    int RequestedType,
    int ItemId,
    InventoryItemCategory Category,
    string Name,
    string DesignTable,
    bool CanEnterNormalBag,
    bool IsUnlockCredential);

/// <summary>
/// Central validation for (item type, item id). A design-table row alone does
/// not make an item a player-inventory item; for costumes the owner must be a
/// playable character. Boss/monster appearances remain valid design data but
/// are deliberately rejected from player costume and normal item flows.
/// </summary>
public static class InventoryItemResolver
{
    public static bool IsPlayerCostume(int id) => Resolve((int)ItemType.Costume, id).Category == InventoryItemCategory.PlayerCostume;

    public static bool IsBossCostume(int id) => Resolve((int)ItemType.Costume, id).Category == InventoryItemCategory.BossCostume;

    public static InventoryItemResolution Resolve(int type, int id, string language = "zh-CN")
    {
        if (id <= 0)
            return Invalid(type, id, "ID: " + id);

        if (type == (int)ItemType.Costume)
        {
            var costume = CostumeManager.GetCostume(id);
            if (costume == null)
                return Invalid(type, id, "ID: " + id);

            // Type == 0 is the dump-confirmed playable-character category.
            // A matching UniqueCharId alone is not enough: boss/monster
            // appearances can also carry a costume-like row.
            var owner = CharManager.GetAll().FirstOrDefault(x =>
                x.Type == 0 && x.UniqueCharId == costume.UseUniqueCharId && x.DefaultCostumeId > 0);
            var name = NameTextManager.GetText(costume.CostumeNameTextId, language);
            if (owner == null)
                return new InventoryItemResolution(true, type, id, InventoryItemCategory.BossCostume,
                    name, "CostumeTable", false, false);

            return new InventoryItemResolution(true, type, id, InventoryItemCategory.PlayerCostume,
                $"{CharManager.GetDisplayName(owner)} / {name}", "CostumeTable", false, false);
        }

        if (type == (int)ItemType.ContentTicket)
            return new InventoryItemResolution(true, type, id, InventoryItemCategory.ContentTicket,
                ItemDesignManager.GetName(type, id, language), "ContentOpenTable", false, true);

        if (type == (int)ItemType.Equip)
        {
            try
            {
                var equip = EquipmentManager.GetEquipmentById(id);
                return new InventoryItemResolution(equip != null, type, id, InventoryItemCategory.Equipment,
                    $"ID:{id}", "EquipmentTable", false, false);
            }
            catch (InvalidOperationException)
            {
                return Invalid(type, id, "ID: " + id);
            }
        }

        if (type == 25)
            return new InventoryItemResolution(true, type, id, InventoryItemCategory.LobbyInteractionTicket,
                ItemDesignManager.GetName(type, id, language), "LobbySettingItemTable", false, true);

        if (type == (int)ItemType.Gold || type == (int)ItemType.FreeJewelry ||
            type == (int)ItemType.Jewelry || type == (int)ItemType.Cash)
            return new InventoryItemResolution(true, type, id, InventoryItemCategory.Currency,
                ItemDesignManager.GetName(type, id, language), "CurrencyTable", false, false);

        var nameResult = ItemDesignManager.GetName(type, id, language);
        var known = !nameResult.StartsWith("ID:", StringComparison.Ordinal);
        var canStack = type == (int)ItemType.Food || type == (int)ItemType.Resource ||
                       type == (int)ItemType.RandomBox || type == (int)ItemType.QuestItem ||
                       type == (int)ItemType.UseItem || type == (int)ItemType.MyRoomNormalItem;
        return new InventoryItemResolution(known, type, id, canStack ? InventoryItemCategory.StackableItem : InventoryItemCategory.Unknown,
            nameResult, "ItemDesignTable", canStack, false);
    }

    private static InventoryItemResolution Invalid(int type, int id, string name) =>
        new(false, type, id, InventoryItemCategory.Unknown, name, "", false, false);
}
