using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_FieldMiniGamePointType
{
	[OriginalName("FMGP_NONE")]
	FmgpNone,
	[OriginalName("FMGP_SCORE")]
	FmgpScore,
	[OriginalName("FMGP_HP")]
	FmgpHp,
	[OriginalName("FMGP_TRAP")]
	FmgpTrap
}
