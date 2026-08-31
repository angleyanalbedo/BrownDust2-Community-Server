using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_PurchaseLimitType
{
	[OriginalName("PL_UNLIMITED")]
	PlUnlimited,
	[OriginalName("PL_DAILY")]
	PlDaily,
	[OriginalName("PL_WEEKLY")]
	PlWeekly,
	[OriginalName("PL_MONTHLY")]
	PlMonthly,
	[OriginalName("PL_ACCOUNT")]
	PlAccount
}
