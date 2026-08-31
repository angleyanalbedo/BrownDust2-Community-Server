using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_MyRoomCharInteractType
{
	[OriginalName("MRCI_STAND")]
	MrciStand,
	[OriginalName("MRCI_LIE_DOWN")]
	MrciLieDown,
	[OriginalName("MRCI_SIT")]
	MrciSit,
	[OriginalName("MRCI_RUN")]
	MrciRun
}
