using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_AttendanceRewardType
{
	[OriginalName("SAR_NONE")]
	SarNone,
	[OriginalName("SPR_STANDARD")]
	SprStandard,
	[OriginalName("SPR_PREMIUM")]
	SprPremium,
	[OriginalName("SPR_MONTHLY1")]
	SprMonthly1,
	[OriginalName("SPR_MONTHLY2")]
	SprMonthly2
}
