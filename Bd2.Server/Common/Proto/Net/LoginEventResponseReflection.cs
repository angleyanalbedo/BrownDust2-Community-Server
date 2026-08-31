using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class LoginEventResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9Mb2dpbkV2ZW50UmVzcG9uc2UucHJvdG8SCXByb3RvLm5l" + "dCJBCg5Mb2dpbkV2ZW50SW5mbxIWCg5sb2dpbl9ldmVudF9pZBgBIAEoBRIX" + "Cg9uZXh0X2xvZ2luX3RpbWUYAiABKAMiSQoSTG9naW5FdmVudFJlc3BvbnNl" + "EjMKEGxvZ2luX2V2ZW50X2luZm8YASADKAsyGS5wcm90by5uZXQuTG9naW5F" + "dmVudEluZm9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(LoginEventInfo), LoginEventInfo.Parser, new string[2] { "LoginEventId", "NextLoginTime" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(LoginEventResponse), LoginEventResponse.Parser, new string[1] { "LoginEventInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
