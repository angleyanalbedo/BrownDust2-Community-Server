using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventMissionInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9FdmVudE1pc3Npb25JbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBogQ29tbW9ucy9FdmVudE1pc3Npb25EQkluZm8ucHJvdG8iTwoYRXZlbnRNaXNzaW9uSW5mb1Jlc3BvbnNlEjMKDG1pc3Npb25faW5mbxgBIAMoCzIdLnByb3RvLm5ldC5FdmVudE1pc3Npb25EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { EventMissionDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventMissionInfoResponse), EventMissionInfoResponse.Parser, new string[1] { "MissionInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
