using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_EventMissionType
{
	[OriginalName("EMR_FIXED_OPEN")]
	EmrFixedOpen,
	[OriginalName("EMR_DAILY_RESET")]
	EmrDailyReset,
	[OriginalName("EMR_WEEKLY_RESET")]
	EmrWeeklyReset,
	[OriginalName("EMR_DAILY_OPEN")]
	EmrDailyOpen
}
