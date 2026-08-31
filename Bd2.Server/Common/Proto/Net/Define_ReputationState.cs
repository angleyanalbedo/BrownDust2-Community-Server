using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_ReputationState
{
	[OriginalName("REPUTATION_STATE_BAD")]
	ReputationStateBad,
	[OriginalName("REPUTATION_STATE_NORMAL")]
	ReputationStateNormal,
	[OriginalName("REPUTATION_STATE_GOOD")]
	ReputationStateGood
}
