using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_MyRoomItemType
{
	[OriginalName("MRIT_SKIN")]
	MritSkin,
	[OriginalName("MRIT_OBJECT")]
	MritObject,
	[OriginalName("MRIT_CARPET")]
	MritCarpet,
	[OriginalName("MRIT_COSTUME")]
	MritCostume
}
