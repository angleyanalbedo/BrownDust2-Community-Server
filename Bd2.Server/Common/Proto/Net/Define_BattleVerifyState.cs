using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_BattleVerifyState
{
	[OriginalName("BATTLE_VERIFY_STATE_NONE")]
	BattleVerifyStateNone = 0,
	[OriginalName("BATTLE_VERIFY_STATE_IN_PROGRESS")]
	BattleVerifyStateInProgress = 1,
	[OriginalName("BATTLE_VERIFY_STATE_SUCCESS")]
	BattleVerifyStateSuccess = 3,
	[OriginalName("BATTLE_VERIFY_STATE_ERROR")]
	BattleVerifyStateError = 4
}
