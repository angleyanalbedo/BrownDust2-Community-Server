using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_TrapType
{
	[OriginalName("FIX_TRAP")]
	FixTrap,
	[OriginalName("ONCE_TRAP")]
	OnceTrap,
	[OriginalName("SCENE_REGEN")]
	SceneRegen
}
