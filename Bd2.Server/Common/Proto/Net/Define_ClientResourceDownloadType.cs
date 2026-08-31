using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_ClientResourceDownloadType
{
	[OriginalName("CRD_NONE")]
	CrdNone,
	[OriginalName("CRD_FULL")]
	CrdFull,
	[OriginalName("CRD_PARTIAL")]
	CrdPartial
}
