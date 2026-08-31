using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_CommunityType
{
	[OriginalName("CT_SURVEY")]
	CtSurvey,
	[OriginalName("CT_COMMUNITY")]
	CtCommunity,
	[OriginalName("CT_SNS")]
	CtSns,
	[OriginalName("CT_YOUTUBE")]
	CtYoutube
}
