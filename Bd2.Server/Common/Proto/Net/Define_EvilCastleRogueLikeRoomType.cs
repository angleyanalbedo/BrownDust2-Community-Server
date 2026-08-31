using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_EvilCastleRogueLikeRoomType
{
	[OriginalName("ECRLRT_NONE")]
	EcrlrtNone,
	[OriginalName("ECRLRT_NORMAL")]
	EcrlrtNormal,
	[OriginalName("ECRLRT_ELITE")]
	EcrlrtElite,
	[OriginalName("ECRLRT_BOSS")]
	EcrlrtBoss,
	[OriginalName("ECRLRT_RELIC")]
	EcrlrtRelic,
	[OriginalName("ECRLRT_EVENT")]
	EcrlrtEvent,
	[OriginalName("ECRLRT_SHOP")]
	EcrlrtShop
}
