using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_HuntDispatchGroupType
{
	[OriginalName("HDG_NONE")]
	HdgNone,
	[OriginalName("HDG_HUNTING_GROUND")]
	HdgHuntingGround,
	[OriginalName("HDG_SKY_WAY")]
	HdgSkyWay
}
