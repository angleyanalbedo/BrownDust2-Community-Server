using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using SqlSugar;
using Bd2.Server.DAO.Game;

namespace Bd2.Server.Pages.Admin;

[Authorize(AuthenticationSchemes = "AdminCookie")]
public class DashboardModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
    private readonly ISqlSugarClient _db;

    public DashboardModel(ISqlSugarClient db) { _db = db; }

    public StatsData Stats { get; set; } = new();

    public class StatsData
    {
        public int PlayerCount { get; set; }
        public int CharCount { get; set; }
        public int EquipCount { get; set; }
        public int ItemCount { get; set; }
        public int MailCount { get; set; }
        public int TodayPlayers { get; set; }
    }

    public async Task OnGetAsync()
    {
        Stats.PlayerCount = await _db.Queryable<UserInfoDao>().CountAsync();
        Stats.CharCount = await _db.Queryable<CharInfoDao>().CountAsync();
        Stats.EquipCount = await _db.Queryable<EquipInfoDao>().CountAsync();
        Stats.ItemCount = await _db.Queryable<ItemInfoDao>().CountAsync();
        Stats.MailCount = await _db.Queryable<MailInfoDao>().CountAsync();

        var todayStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, DateTimeKind.Local);
        long todayStartTs = new DateTimeOffset(todayStart).ToUnixTimeMilliseconds();
        Stats.TodayPlayers = await _db.Queryable<UserInfoDao>()
            .Where(x => x.LoginDate >= todayStartTs)
            .CountAsync();
    }
}
