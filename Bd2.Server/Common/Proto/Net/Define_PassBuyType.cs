using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_PassBuyType
{
	[OriginalName("PB_LEVEL")]
	PbLevel,
	[OriginalName("PB_PREMIUM_1")]
	PbPremium1,
	[OriginalName("PB_MAIN")]
	PbMain,
	[OriginalName("PB_PREMIUM_2")]
	PbPremium2
}
