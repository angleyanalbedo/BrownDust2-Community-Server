using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_MyRoomInvenType
{
	[OriginalName("MRIV_ALL")]
	MrivAll,
	[OriginalName("MRIV_OBJECT_FLOOR")]
	MrivObjectFloor,
	[OriginalName("MRIV_OBJECT_WALL")]
	MrivObjectWall,
	[OriginalName("MRIV_CARPET")]
	MrivCarpet,
	[OriginalName("MRIV_COSTUME")]
	MrivCostume,
	[OriginalName("MRIV_SKIN_WALL")]
	MrivSkinWall,
	[OriginalName("MRIV_SKIN_FLOOR")]
	MrivSkinFloor
}
