using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_ScheduleStateType
{
	[OriginalName("SCHEDULE_SEASON")]
	ScheduleSeason,
	[OriginalName("SCHEDULE_OFF_SEASON")]
	ScheduleOffSeason,
	[OriginalName("SCHEDULE_CALCULATE")]
	ScheduleCalculate,
	[OriginalName("SCHEDULE_COMING_SOON")]
	ScheduleComingSoon
}
