using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_GachaBuyType
{
	[OriginalName("GB_FREE")]
	GbFree,
	[OriginalName("GB_NORMAL")]
	GbNormal,
	[OriginalName("GB_CASH")]
	GbCash
}
