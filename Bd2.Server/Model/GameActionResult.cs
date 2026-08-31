using EasyTool;

namespace Bd2.Server.Model;

public class GameActionResult
{
	public int errorType { get; set; }

	public int packetCode { get; set; }

	public string errorMessage { get; set; } = "";

	public int length { get; set; }

	public string data { get; set; }

	public long serverNowTime { get; set; } = TimestampUtil.GetCurrentTimestamp();

	public string notify { get; set; } = "";
}
