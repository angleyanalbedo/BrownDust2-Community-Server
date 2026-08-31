using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_AttendanceLimitType
{
	[OriginalName("LIMIT_ALREADY_REWARD")]
	LimitAlreadyReward,
	[OriginalName("LIMIT_ENABLE_REWARD")]
	LimitEnableReward,
	[OriginalName("LIMIT_DISABLE_REWARD")]
	LimitDisableReward
}
