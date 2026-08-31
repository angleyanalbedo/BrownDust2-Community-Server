using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_StatueType
{
	[OriginalName("RS_NONE")]
	RsNone,
	[OriginalName("RS_PVP")]
	RsPvp,
	[OriginalName("RS_EVIL_CASTLE")]
	RsEvilCastle,
	[OriginalName("RS_MONSTER_HUNT")]
	RsMonsterHunt,
	[OriginalName("RS_MAX")]
	RsMax
}
