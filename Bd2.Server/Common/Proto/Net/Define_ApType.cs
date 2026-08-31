using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_ApType
{
	[OriginalName("AP_TYPE_NONE")]
	ApTypeNone,
	[OriginalName("AP_TYPE_HUNTING")]
	ApTypeHunting,
	[OriginalName("AP_TYPE_TORCH_LIGHT")]
	ApTypeTorchLight
}
