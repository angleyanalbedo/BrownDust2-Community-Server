using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using Bd2.Server.DAO.Account;

namespace Bd2.Server.Pages.Admin;

public class LoginModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
    private readonly ISqlSugarClient _db;

    [BindProperty]
    public InputModel Input { get; set; } = new();

    public string? ErrorMessage { get; set; }

    public class InputModel
    {
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
    }

    public LoginModel(ISqlSugarClient db)
    {
        _db = db;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        // 检查是否有管理员账户，没有则跳转注册页
        var hasAdmin = await _db.Queryable<AccountDao>()
            .Where(x => x.Role >= 1)
            .AnyAsync();

        if (!hasAdmin)
        {
            return RedirectToPage("/Admin/Register");
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        // 同样检查，防止直接 POST 绕过
        var hasAdmin = await _db.Queryable<AccountDao>()
            .Where(x => x.Role >= 1)
            .AnyAsync();

        if (!hasAdmin)
        {
            return RedirectToPage("/Admin/Register");
        }

        var account = _db.Queryable<AccountDao>()
            .Single(x => x.UserName == Input.UserName);

        if (account == null)
        {
            ErrorMessage = "账号不存在";
            return Page();
        }

        if (account.Password != Input.Password)
        {
            ErrorMessage = "密码错误";
            return Page();
        }

        if (account.Role < 1)
        {
            ErrorMessage = "无管理员权限";
            return Page();
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, account.UserName),
            new Claim("Role", account.Role.ToString())
        };

        var identity = new ClaimsIdentity(claims, "AdminCookie");
        var principal = new ClaimsPrincipal(identity);

        await HttpContext.SignInAsync("AdminCookie", principal);

        return RedirectToPage("/Admin/Dashboard");
    }
}
