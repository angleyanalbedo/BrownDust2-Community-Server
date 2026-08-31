using System.Threading.Tasks;
using EasyTool;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using Bd2.Server.DAO.Game;
using Bd2.Server.Common.Enums;
using Bd2.Server.Common.Managers;

namespace Bd2.Server.Pages.Admin;

[Authorize(AuthenticationSchemes = "AdminCookie")]
public class MailModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
    private readonly ISqlSugarClient _db;

    public MailModel(ISqlSugarClient db) { _db = db; }

    [BindProperty]
    public InputModel Input { get; set; } = new();

    public string? Message { get; set; }
    public bool IsSuccess { get; set; }

    public class InputModel
    {
        public string Uid { get; set; } = "";
        public int Type { get; set; } = 2;
        public int ItemId { get; set; }
        public int Count { get; set; } = 1;
        public string Title { get; set; } = "管理员邮件";
    }

    public void OnGet(string? uid)
    {
        if (uid != null) Input.Uid = uid;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var user = await _db.Queryable<UserInfoDao>()
            .Where(x => x.UserId == Input.Uid)
            .FirstAsync();

        if (user == null)
        {
            Message = "用户不存在";
            IsSuccess = false;
            return Page();
        }

        var type = (ItemType)Input.Type;
        var isCurrency = type == ItemType.Gold || type == ItemType.Jewelry || type == ItemType.FreeJewelry;
        if (!isCurrency)
        {
            var resolved = InventoryItemResolver.Resolve(Input.Type, Input.ItemId);
            if (!resolved.IsValid)
            {
                Message = $"物品无效或未找到设计数据：类型 {Input.Type}，ID {Input.ItemId}";
                IsSuccess = false;
                return Page();
            }

            if (resolved.Category == InventoryItemCategory.BossCostume)
            {
                Message = $"不能通过邮件发送 Boss/怪物外观：{resolved.Name}（ID: {Input.ItemId}）";
                IsSuccess = false;
                return Page();
            }
        }

        var mail = new MailInfoDao
        {
            Uid = user.OwnerIndex,
            Type = 2,
            MailId = 1,
            SenderText = "Admin",
            TitleText = Input.Title,
            MessageText = "",
            RewardExpireTime = 1882926205000L,
            ItemType = Input.Type,
            ItemId = Input.ItemId,
            ItemCount = Input.Count,
            IsOpen = 0,
            OpenTime = 0L,
            CreateTime = TimestampUtil.GetCurrentTimestamp(),
            HistoryDeleteTime = 0L,
            IsCash = 0
        };

        await _db.Insertable(mail).ExecuteCommandAsync();

        Message = "发送成功";
        IsSuccess = true;
        return Page();
    }
}
