using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Bd2.Server.DAO.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SqlSugar;

namespace Bd2.Server.Pages.Admin;

[IgnoreAntiforgeryToken]
public class RegisterModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
    private readonly ISqlSugarClient _db;

    [BindProperty]
    public InputModel Input { get; set; } = new();

    public string? ErrorMessage { get; set; }

    public class InputModel
    {
        [Required(ErrorMessage = "请输入用户名")]
        public string UserName { get; set; } = "";

        [Required(ErrorMessage = "请输入密码")]
        [MinLength(6, ErrorMessage = "密码至少6位")]
        public string Password { get; set; } = "";

        [Required(ErrorMessage = "请确认密码")]
        [Compare("Password", ErrorMessage = "两次密码不一致")]
        public string ConfirmPassword { get; set; } = "";
    }

    public RegisterModel(ISqlSugarClient db) { _db = db; }

    public void OnGet() { }

    public async Task<IActionResult> OnPostAsync()
    {
        // 检查是否已有管理员
        var existingAdmin = await _db.Queryable<AccountDao>()
            .Where(x => x.Role >= 1)
            .FirstAsync();

        if (existingAdmin != null)
        {
            ErrorMessage = "管理员账户已存在，请直接登录";
            return Page();
        }

        // 检查用户名是否已存在
        var existUser = await _db.Queryable<AccountDao>()
            .Where(x => x.UserName == Input.UserName)
            .FirstAsync();

        if (existUser != null)
        {
            ErrorMessage = "用户名已存在";
            return Page();
        }

        // 创建管理员账户（Role=1）
        var account = new AccountDao
        {
            UserName = Input.UserName,
            Password = Input.Password, // TODO: 后续加哈希
            Role = 1
        };

        await _db.Insertable(account).ExecuteCommandAsync();

        return RedirectToPage("/Admin/Login");
    }
}
