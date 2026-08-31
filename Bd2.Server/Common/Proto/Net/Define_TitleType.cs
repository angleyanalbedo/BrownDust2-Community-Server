using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_TitleType
{
	[OriginalName("TITLE_NONE")]
	TitleNone,
	[OriginalName("TITLE_RANK_1")]
	TitleRank1,
	[OriginalName("TITLE_RANK_10")]
	TitleRank10
}
