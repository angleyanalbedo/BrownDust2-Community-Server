using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_MyRoomItemObejctType
{
	[OriginalName("MRIOT_DEFAULT")]
	MriotDefault,
	[OriginalName("MRIOT_COSTUME")]
	MriotCostume,
	[OriginalName("MRIOT_TROPHY")]
	MriotTrophy
}
