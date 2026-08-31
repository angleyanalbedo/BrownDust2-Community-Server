using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using Bd2.Server.DAO.Game;
using Bd2.Server.Common.Managers;

namespace Bd2.Server.Pages.Admin;

[Authorize(AuthenticationSchemes = "AdminCookie")]
public class PlayerDetailModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
    private readonly ISqlSugarClient _db;

    public PlayerDetailModel(ISqlSugarClient db) { _db = db; }

    public UserInfoDao? User { get; set; }
    public List<CharInfoDao> Chars { get; set; } = new();
    public List<EquipInfoDao> Equips { get; set; } = new();
    public List<ItemInfoDao> Items { get; set; } = new();
    public Dictionary<int, string> CharNames { get; set; } = new();
    public Dictionary<int, string> EquipNames { get; set; } = new();
    public Dictionary<long, string> ItemNames { get; set; } = new();

    public async Task OnGetAsync(long id)
    {
        User = await _db.Queryable<UserInfoDao>().Where(x => x.OwnerIndex == id).FirstAsync();
        if (User == null) return;

        Chars = await _db.Queryable<CharInfoDao>().Where(x => x.Uid == id).ToListAsync();
        Equips = await _db.Queryable<EquipInfoDao>().Where(x => x.Uid == id).ToListAsync();
        Items = await _db.Queryable<ItemInfoDao>().Where(x => x.Uid == id).ToListAsync();

        LoadDesignNames();
    }

    private void LoadDesignNames()
    {
        foreach (var c in Chars)
        {
            if (CharNames.ContainsKey(c.Id)) continue;
            try
            {
                var t = CharManager.GetCharData(c.Id);
                CharNames[c.Id] = t == null ? $"ID:{c.Id}" : CharManager.GetDisplayName(t);
            }
            catch
            {
                CharNames[c.Id] = $"ID:{c.Id}";
            }
        }

        foreach (var e in Equips)
        {
            if (EquipNames.ContainsKey(e.Id)) continue;
            try
            {
                var t = EquipmentManager.GetEquipmentById(e.Id);
                EquipNames[e.Id] = t == null ? $"ID:{e.Id}" : NameTextManager.GetText(t.ItemNameTextId);
            }
            catch
            {
                EquipNames[e.Id] = $"ID:{e.Id}";
            }
        }

        foreach (var i in Items)
            ItemNames[i.InvenIndex] = ItemDesignManager.GetName(i.Type, i.Id);
    }

    public async Task<IActionResult> OnPostUpdatePlayerAsync(long OwnerIndex, long Gold, long Jewelry, long FreeJewelry, int Exp)
    {
        await _db.Updateable<UserInfoDao>()
            .SetColumns(x => new UserInfoDao { Gold = Gold, Jewelry = Jewelry, FreeJewelry = FreeJewelry, Exp = Exp })
            .Where(x => x.OwnerIndex == OwnerIndex)
            .ExecuteCommandAsync();

        return RedirectToPage(new { id = OwnerIndex });
    }

    public async Task<IActionResult> OnPostUpdateCharAsync(long InvenIndex, int Level, long Hp, int TalentLevel)
    {
        await _db.Updateable<CharInfoDao>()
            .SetColumns(x => new CharInfoDao { Level = Level, Hp = Hp, TalentLevel = TalentLevel })
            .Where(x => x.InvenIndex == InvenIndex)
            .ExecuteCommandAsync();

        var charInfo = await _db.Queryable<CharInfoDao>().Where(x => x.InvenIndex == InvenIndex).FirstAsync();
        return RedirectToPage(new { id = charInfo?.Uid ?? 0 });
    }

    public async Task<IActionResult> OnPostAddCharAsync(long OwnerIndex, int CharId, int Level, long Hp, int TalentLevel)
    {
        var existing = await _db.Queryable<CharInfoDao>()
            .Where(x => x.Uid == OwnerIndex && x.Id == CharId)
            .FirstAsync();
        if (existing != null)
        {
            return RedirectToPage(new { id = OwnerIndex });
        }

        var newChar = new CharInfoDao
        {
            Uid = OwnerIndex,
            Id = CharId,
            Level = Level,
            Hp = Hp,
            TalentLevel = TalentLevel,
            TalentExp = 0,
            Exp = 0,
            CostumeId = 0,
            UseCostume = 0,
            ExpiryTime = 0,
            ConnectPotentialCostume = 0,
            UniqueCharId = 0,
            SolidarityReward = 0
        };

        await _db.Insertable(newChar).ExecuteCommandAsync();
        return RedirectToPage(new { id = OwnerIndex });
    }

    public async Task<IActionResult> OnPostDeleteCharAsync(long OwnerIndex, long InvenIndex)
    {
        await _db.Deleteable<CharInfoDao>().Where(x => x.Uid == OwnerIndex && x.InvenIndex == InvenIndex).ExecuteCommandAsync();
        return RedirectToPage(new { id = OwnerIndex });
    }

    public string FmtTs(long ts)
    {
        if (ts == 0) return "-";
        var dt = ts < 1e12 ? DateTimeOffset.FromUnixTimeSeconds(ts) : DateTimeOffset.FromUnixTimeMilliseconds(ts);
        return dt.LocalDateTime.ToString("yyyy-MM-dd HH:mm");
    }
}
