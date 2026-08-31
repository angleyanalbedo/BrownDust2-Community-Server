using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_EvilCastleRogueLikeStateType
{
	[OriginalName("ECRLST_NONE")]
	EcrlstNone,
	[OriginalName("ECRLST_CHOICE_COSTUME")]
	EcrlstChoiceCostume,
	[OriginalName("ECRLST_CHOICE_RELIC")]
	EcrlstChoiceRelic,
	[OriginalName("ECRLST_BATTLE")]
	EcrlstBattle,
	[OriginalName("ECRLST_SHOP")]
	EcrlstShop,
	[OriginalName("ECRLST_EVENT")]
	EcrlstEvent,
	[OriginalName("ECRLST_SELECT_CHANGE_RELIC")]
	EcrlstSelectChangeRelic,
	[OriginalName("ECRLST_SELECT_REMOVE_RELIC")]
	EcrlstSelectRemoveRelic
}
