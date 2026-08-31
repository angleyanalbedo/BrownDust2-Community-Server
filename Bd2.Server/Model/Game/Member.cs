namespace Bd2.Server.Model.Game;

public class Member
{
	public long crt_id { get; set; } = 1687595312000L;

	public long upd_dt { get; set; } = 1711543314000L;

	public string status_cd { get; set; } = "OK";

	public int member_id { get; set; }

	public string nickname { get; set; } = "User";

	public string? profile_img_url { get; set; }

	public string? feeling { get; set; }

	public string adult_auth_yn { get; set; } = "N";

	public string? adult_auth_dt { get; set; }

	public long recent_login_dt { get; set; } = 1711543314000L;

	public int recent_app_id { get; set; } = 5063;

	public string? email { get; set; }

	public string anonymous_yn { get; set; } = "N";

	public string? friend_accept_cd { get; set; }

	public string reg_path { get; set; } = "FIREBASE_google";

	public string? recent_app_title { get; set; }

	public string? last_msg_dt { get; set; }

	public string? new_msg_yn { get; set; }

	public int conflict_member_id { get; set; }

	public string reg_ip { get; set; } = "127.0.0.1";

	public string reg_nation { get; set; } = "jp";

	public bool is_guest_login { get; set; }

	public string? provider_display_name { get; set; }

	public string? pushgroup { get; set; }

	public string? locale { get; set; }
}
