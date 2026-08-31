using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_MissionGroupType
{
	[OriginalName("MGT_DAILY")]
	MgtDaily,
	[OriginalName("MGT_WEEKLY")]
	MgtWeekly,
	[OriginalName("MGT_EVENT")]
	MgtEvent
}
