using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public enum Define_NoticeType
{
	[OriginalName("NT_NOTICE")]
	NtNotice,
	[OriginalName("NT_EVENT")]
	NtEvent,
	[OriginalName("NT_UPDATE")]
	NtUpdate,
	[OriginalName("NT_SURVEY")]
	NtSurvey,
	[OriginalName("NT_EMERGENCY")]
	NtEmergency,
	[OriginalName("NT_DEVELOPER_NOTE")]
	NtDeveloperNote
}
