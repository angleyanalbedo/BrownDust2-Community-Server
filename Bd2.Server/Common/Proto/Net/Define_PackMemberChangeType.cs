using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_PackMemberChangeType
{
	[OriginalName("MEMBER_CHANGE_NOT_USE")]
	MemberChangeNotUse,
	[OriginalName("MEMBER_CHANGE_ALL_USE")]
	MemberChangeAllUse,
	[OriginalName("MEMBER_CHANGE_SAFE_ZONE_USE")]
	MemberChangeSafeZoneUse
}
