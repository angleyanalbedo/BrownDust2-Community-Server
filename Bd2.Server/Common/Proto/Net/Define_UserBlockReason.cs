using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_UserBlockReason
{
	[OriginalName("USER_BLOCK_REASON_NONE")]
	UserBlockReasonNone,
	[OriginalName("USER_BLOCK_REASON_POLICY_VIOLATION")]
	UserBlockReasonPolicyViolation,
	[OriginalName("USER_BLOCK_REASON_ILLEGAL_PROGRAM_USE")]
	UserBlockReasonIllegalProgramUse,
	[OriginalName("USER_BLOCK_REASON_DATA_TAMPERING")]
	UserBlockReasonDataTampering,
	[OriginalName("USER_BLOCK_REASON_SYSTEM_EXPLOITATION")]
	UserBlockReasonSystemExploitation,
	[OriginalName("USER_BLOCK_REASON_ABNORMAL_PAYMENT")]
	UserBlockReasonAbnormalPayment,
	[OriginalName("USER_BLOCK_REASON_ABUSING")]
	UserBlockReasonAbusing
}
