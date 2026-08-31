using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Bd2.Server.Pages.Admin;

public class LogoutModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
    public async Task<IActionResult> OnGetAsync()
    {
        await HttpContext.SignOutAsync("AdminCookie");
        return RedirectToPage("/Admin/Login");
    }
}
