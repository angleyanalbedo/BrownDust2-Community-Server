using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_SkyWayDungeonLevelType
{
	[OriginalName("SKDL_NORMAL")]
	SkdlNormal,
	[OriginalName("SKDL_DIFFICULT")]
	SkdlDifficult,
	[OriginalName("SKDL_VERY_DIFFICULT")]
	SkdlVeryDifficult
}
