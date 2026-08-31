using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_EquipRankType
{
	[OriginalName("NONE_EQUIP_RANK")]
	NoneEquipRank,
	[OriginalName("C")]
	C,
	[OriginalName("B")]
	B,
	[OriginalName("A")]
	A,
	[OriginalName("S")]
	S
}
