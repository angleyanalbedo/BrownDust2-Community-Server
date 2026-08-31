using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_PackRewardObjectCountType
{
	[OriginalName("PROCT_NONE")]
	ProctNone,
	[OriginalName("PROCT_RESEARCH")]
	ProctResearch,
	[OriginalName("PROCT_ONCE")]
	ProctOnce,
	[OriginalName("PROCT_REWARD")]
	ProctReward,
	[OriginalName("PROCT_EVENT_LOST_COIN")]
	ProctEventLostCoin
}
