using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_ProductTimeLimitType
{
	[OriginalName("PTL_UNLIMITED")]
	PtlUnlimited,
	[OriginalName("PTL_LIMITED")]
	PtlLimited,
	[OriginalName("PTL_LIMITED_PURCHASE_COUNT_RESET")]
	PtlLimitedPurchaseCountReset,
	[OriginalName("PTL_LIMITED_USER_CUSTOM_ACTIVE")]
	PtlLimitedUserCustomActive
}
