using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using SqlSugar;
using Bd2.Server.Common.DB;
using Bd2.Server.DAO.Account;
using Bd2.Server.DAO.Game;

namespace Bd2.Server.Pages.Admin;

[Authorize(AuthenticationSchemes = "AdminCookie")]
public class PlayersModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
    private readonly ISqlSugarClient _db;

    public PlayersModel(ISqlSugarClient db) { _db = db; }

    public List<PlayerListItem> Players { get; set; } = new();
    public string Keyword { get; set; } = "";
    public int Page { get; set; } = 1;
    public int TotalPages { get; set; }
    private const int PageSize = 20;

    public sealed class PlayerListItem
    {
        public UserInfoDao User { get; init; } = null!;
        public string Email { get; init; } = "";
    }

    public async Task OnGetAsync(int page = 1, string? kw = null)
    {
        Keyword = kw ?? "";
        Page = Math.Max(1, page);

        // UserInfoDao belongs to the game database. The login email is stored in
        // the main database, keyed by the member id used as UserInfo.OwnerIndex.
        var mainDb = ((SqlSugarScope)_db).GetConnectionScope("main");
        var accounts = await mainDb.Queryable<NeonAccountDao>().ToListAsync();
        var emailByMemberId = accounts
            .Where(x => x.MemberId > 0 && !string.IsNullOrWhiteSpace(x.Email))
            .GroupBy(x => x.MemberId)
            .ToDictionary(x => x.Key, x => x.First().Email);

        var matchingMemberIds = string.IsNullOrWhiteSpace(Keyword)
            ? new List<long>()
            : accounts
                .Where(x => !string.IsNullOrWhiteSpace(x.Email) &&
                            x.Email.Contains(Keyword, StringComparison.OrdinalIgnoreCase))
                .Select(x => x.MemberId)
                .Where(x => x > 0)
                .Distinct()
                .ToList();

        var query = _db.Queryable<UserInfoDao>();
        if (!string.IsNullOrWhiteSpace(Keyword))
            query = query.Where(x => x.UserId.Contains(Keyword) || matchingMemberIds.Contains(x.OwnerIndex));

        var total = await query.CountAsync();
        TotalPages = (int)Math.Ceiling((double)total / PageSize);

        var users = await query
            .OrderByDescending(x => x.LoginDate)
            .Skip((Page - 1) * PageSize)
            .Take(PageSize)
            .ToListAsync();

        Players = users.Select(user => new PlayerListItem
        {
            User = user,
            Email = emailByMemberId.TryGetValue(user.OwnerIndex, out var email)
                ? email
                : "未绑定邮箱"
        }).ToList();
    }
}
