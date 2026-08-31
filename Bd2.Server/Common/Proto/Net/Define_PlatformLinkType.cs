using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_PlatformLinkType
{
	[OriginalName("PLATFORM_LINK_TYPE_LINK")]
	PlatformLinkTypeLink,
	[OriginalName("PLATFORM_LINK_TYPE_SWAP")]
	PlatformLinkTypeSwap,
	[OriginalName("PLATFORM_LINK_TYPE_CONFLICT_LINK")]
	PlatformLinkTypeConflictLink
}
