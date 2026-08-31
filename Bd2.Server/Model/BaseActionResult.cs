namespace Bd2.Server.Model;

public class BaseActionResult
{
	public int errorType { get; set; }

	public int packetCode { get; set; }

	public string errorMessage { get; set; } = "";

	public string data { get; set; }

	public int length { get; set; }

	public long serverNowTime { get; set; }

	public string notify { get; set; } = "";

	public string ip { get; set; } = "127.0.0.1";
}
