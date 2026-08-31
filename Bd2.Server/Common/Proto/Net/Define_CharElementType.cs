using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_CharElementType
{
	[OriginalName("CET_WATER")]
	CetWater,
	[OriginalName("CET_FIRE")]
	CetFire,
	[OriginalName("CET_WIND")]
	CetWind,
	[OriginalName("CET_LIGHT")]
	CetLight,
	[OriginalName("CET_DARK")]
	CetDark
}
