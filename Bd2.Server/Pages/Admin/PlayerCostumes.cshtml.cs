using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bd2.Server.Common.DB;
using Bd2.Server.Common.Managers;
using Bd2.Server.Common.Enums;
using Bd2.Server.Common.Proto.Design.common;
using Bd2.Server.DAO.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;

namespace Bd2.Server.Pages.Admin;

[Authorize(AuthenticationSchemes = "AdminCookie")]
public class PlayerCostumesModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
    private readonly ISqlSugarClient _db;
    public PlayerCostumesModel(ISqlSugarClient db) => _db = db;
    public long Uid { get; set; }
    public List<CostumeInfoDao> Costumes { get; set; } = new();
    public List<PrestigeSkinInfoDao> PrestigeSkins { get; set; } = new();
    public List<CharInfoDao> Chars { get; set; } = new();
    public List<(int Id, string Name)> CostumeOptions { get; set; } = new();
    public List<(int Id, string Name)> BossCostumeOptions { get; set; } = new();
    public List<(long Id, string Name)> CharacterOptions { get; set; } = new();
    public List<(int CostumeId, int DesignId, string Name)> PrestigeOptions { get; set; } = new();
    public List<(int CostumeId, int DesignId, string Name)> SpecialOptions { get; set; } = new();

    public void OnGet(long id) => Load(id);

    public async Task<IActionResult> OnPostAddAsync(long Uid, int CostumeId, int Level = 1)
    {
        var costume = CostumeManager.GetCostume(CostumeId);
        var resolution = InventoryItemResolver.Resolve((int)ItemType.Costume, CostumeId);
        if (costume == null || resolution.Category != InventoryItemCategory.PlayerCostume) return RedirectToPage(new { id = Uid });
        if (await _db.Queryable<CostumeInfoDao>().AnyAsync(x => x.Uid == Uid && x.Id == CostumeId)) return RedirectToPage(new { id = Uid });
        var chars = await _db.Queryable<CharInfoDao>().Where(x => x.Uid == Uid).ToListAsync();
        var owner = chars.FirstOrDefault(x => CharManager.GetCharData(x.Id)?.UniqueCharId == costume.UseUniqueCharId);
        await _db.Insertable(new CostumeInfoDao
        {
            Uid = Uid,
            Id = CostumeId,
            Level = Math.Max(0, Level),
            UseChar = owner?.InvenIndex,
            SortId = 0,
            UseMyRoomCount = 0,
            PotentialId = null
        }).ExecuteCommandAsync();
        return RedirectToPage(new { id = Uid });
    }

    public async Task<IActionResult> OnPostUpdateAsync(long Uid, long InvenIndex, int Level)
    {
        await _db.Updateable<CostumeInfoDao>().SetColumns(x => new CostumeInfoDao { Level = Math.Max(1, Level) }).Where(x => x.Uid == Uid && x.InvenIndex == InvenIndex).ExecuteCommandAsync();
        return RedirectToPage(new { id = Uid });
    }

    public async Task<IActionResult> OnPostDeleteAsync(long Uid, long InvenIndex)
    {
        await _db.Deleteable<CostumeInfoDao>().Where(x => x.Uid == Uid && x.InvenIndex == InvenIndex).ExecuteCommandAsync();
        return RedirectToPage(new { id = Uid });
    }

    public async Task<IActionResult> OnPostPrestigeAsync(long Uid, int CostumeId, int CostumeDesignId, bool IsSet)
    {
        var row = await _db.Queryable<PrestigeSkinInfoDao>().Where(x => x.Uid == Uid && x.CostumeId == CostumeId && x.CostumeDesignId == CostumeDesignId).FirstAsync();
        if (row == null) await _db.Insertable(new PrestigeSkinInfoDao { Uid = Uid, CostumeId = CostumeId, CostumeDesignId = CostumeDesignId, IsSet = IsSet ? 1 : 0 }).ExecuteCommandAsync();
        else await _db.Updateable<PrestigeSkinInfoDao>().SetColumns(x => new PrestigeSkinInfoDao { IsSet = IsSet ? 1 : 0 }).Where(x => x.Index == row.Index).ExecuteCommandAsync();
        return RedirectToPage(new { id = Uid });
    }

    public async Task<IActionResult> OnPostUnsetPrestigeAsync(long Uid, long Index)
    {
        await _db.Updateable<PrestigeSkinInfoDao>()
            .SetColumns(x => new PrestigeSkinInfoDao { IsSet = 0 })
            .Where(x => x.Uid == Uid && x.Index == Index)
            .ExecuteCommandAsync();
        return RedirectToPage(new { id = Uid });
    }

    public async Task<IActionResult> OnPostDeletePrestigeAsync(long Uid, long Index)
    {
        await _db.Deleteable<PrestigeSkinInfoDao>()
            .Where(x => x.Uid == Uid && x.Index == Index)
            .ExecuteCommandAsync();
        return RedirectToPage(new { id = Uid });
    }

    private void Load(long id)
    {
        Uid = id;
        Costumes = _db.Queryable<CostumeInfoDao>().Where(x => x.Uid == id).ToList();
        PrestigeSkins = _db.Queryable<PrestigeSkinInfoDao>().Where(x => x.Uid == id).ToList();
        Chars = _db.Queryable<CharInfoDao>().Where(x => x.Uid == id).ToList();
        var allCostumes = DesignDbHelper.LoadFromCommon("CostumeTable", CostumeTable.Parser)
            .Where(x => x.Id != 0)
            .Select(x => new { x.Id, Name = $"{CharacterName(x.UseUniqueCharId)} / {NameTextManager.GetText(x.CostumeNameTextId)}", Resolution = InventoryItemResolver.Resolve((int)ItemType.Costume, x.Id) })
            .Where(x => x.Resolution.IsValid)
            .ToList();
        CostumeOptions = allCostumes.Where(x => x.Resolution.Category == InventoryItemCategory.PlayerCostume)
            .Select(x => (x.Id, x.Name)).Distinct().OrderBy(x => x.Id).ToList();
        BossCostumeOptions = allCostumes.Where(x => x.Resolution.Category == InventoryItemCategory.BossCostume)
            .Select(x => (x.Id, x.Name)).Distinct().OrderBy(x => x.Id).ToList();
        CharacterOptions = Chars.Select(x => (x.InvenIndex, $"{CharacterName(x)} (ID: {x.Id})")).ToList();
        var definitions = DesignDbHelper.LoadRawFromCommon("PrestigeSkinTable")
            .Select(x => ParsePrestigeSkin(x.Id, x.ProtoBuf))
            .Where(x => x.HasValue)
            .Select(x => x!.Value)
            .Where(x => CostumeManager.GetCostume(x.CostumeId) != null)
            .Select(x => (x.CostumeId, x.Id, x.SkinType, $"{Name(x.CostumeId)} / {NameTextManager.GetText(x.SkinNameTextId)}"))
            .Distinct().OrderBy(x => x.Id).ToList();
        PrestigeOptions = definitions.Where(x => x.SkinType != 1).Select(x => (x.CostumeId, x.Id, x.Item4)).ToList();
        SpecialOptions = definitions.Where(x => x.SkinType == 1).Select(x => (x.CostumeId, x.Id, x.Item4)).ToList();
    }

    private static (int Id, int CostumeId, int SkinType, int SkinNameTextId)? ParsePrestigeSkin(long id, byte[] data)
    {
        var costumeId = 0; var skinType = 0; var skinNameTextId = 0;
        var current = 0;
        for (var i = 0; i < data.Length;)
        {
            var tag = ReadVarint(data, ref i);
            var field = (int)(tag >> 3);
            var wire = (int)(tag & 7);
            if (wire == 0)
            {
                var value = ReadVarint(data, ref i);
                if (field == 1) costumeId = (int)value;
                if (field == 4) current = (int)value;
                if (field == 9) skinType = (int)value;
                if (field == 5) skinNameTextId = (int)value;
            }
            else if (wire == 2)
            {
                var length = (int)ReadVarint(data, ref i);
                i += length;
            }
            else if (wire == 1) i += 8;
            else if (wire == 5) i += 4;
            else return null;
        }
        return costumeId == 0 ? null : (current == 0 ? (int)id : current, costumeId, skinType, skinNameTextId);
    }

    private static ulong ReadVarint(byte[] data, ref int offset)
    {
        ulong value = 0; var shift = 0;
        while (offset < data.Length)
        {
            var b = data[offset++]; value |= (ulong)(b & 127) << shift;
            if ((b & 128) == 0) return value;
            shift += 7;
        }
        throw new InvalidOperationException("Invalid PrestigeSkinTable protobuf");
    }

    public string Name(int id)
    {
        var x = CostumeManager.GetCostume(id);
        if (x == null) return $"ID:{id}";
        var character = CharManager.GetAll().FirstOrDefault(c => c.UniqueCharId == x.UseUniqueCharId);
        var characterName = character == null ? $"角色:{x.UseUniqueCharId}" : CharManager.GetDisplayName(character);
        return $"{characterName} / {NameTextManager.GetText(x.CostumeNameTextId)}";
    }

    private static string CharacterName(CharInfoDao character)
    {
        var design = CharManager.GetCharData(character.Id);
        return design == null ? $"未知角色" : CharManager.GetDisplayName(design);
    }

    private static string CharacterName(int uniqueCharId)
    {
        var design = CharManager.GetAll().FirstOrDefault(x => x.UniqueCharId == uniqueCharId);
        return design == null ? $"未知角色 ({uniqueCharId})" : CharManager.GetDisplayName(design);
    }
}
