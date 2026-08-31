using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_MailType
{
	[OriginalName("MT_INGAME_REWARD")]
	MtIngameReward,
	[OriginalName("MT_ADMIN_REWARD")]
	MtAdminReward,
	[OriginalName("MT_EVENT_REWARD")]
	MtEventReward,
	[OriginalName("MT_TOTAL_WAR_DAILY_REWARD")]
	MtTotalWarDailyReward
}
