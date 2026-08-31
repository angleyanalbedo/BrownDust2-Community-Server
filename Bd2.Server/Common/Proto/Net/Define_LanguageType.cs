using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_LanguageType
{
	[OriginalName("LANG_NONE")]
	LangNone,
	[OriginalName("KOREA")]
	Korea,
	[OriginalName("ENGLISH")]
	English,
	[OriginalName("JAPAN")]
	Japan,
	[OriginalName("TAIWAN")]
	Taiwan,
	[OriginalName("CHINA")]
	China
}
