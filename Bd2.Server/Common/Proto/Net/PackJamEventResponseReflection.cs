using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackJamEventResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9QYWNrSmFtRXZlbnRSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8iSAoUUGFja0phbUV2ZW50UmVzcG9uc2USMAoRcGFja19ldmVudF9yZXdhcmQYASABKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackJamEventResponse), PackJamEventResponse.Parser, new string[1] { "PackEventReward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
