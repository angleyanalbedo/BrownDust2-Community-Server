namespace Bd2.Server.Model.Game;

public class WebToken
{
	public string access_token { get; set; }

	public Member member { get; set; }

	public string? force_receipt { get; set; }

	public string? conflict_member_id { get; set; }

	public bool is_guest_login { get; set; }

	public string? old_member_id { get; set; }

	public string? jailbreak_yn { get; set; }

	public string? fcm_send_lang { get; set; }

	public string unreg_status { get; set; } = "NO";

	public string? unreg_remain_time { get; set; }

	public int callTime { get; set; }
}
