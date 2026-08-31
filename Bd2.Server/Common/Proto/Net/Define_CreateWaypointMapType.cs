using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_CreateWaypointMapType
{
	[OriginalName("CREATE_WAYPOINT_SAFE")]
	CreateWaypointSafe,
	[OriginalName("CREATE_WAYPOINT_ALL")]
	CreateWaypointAll
}
