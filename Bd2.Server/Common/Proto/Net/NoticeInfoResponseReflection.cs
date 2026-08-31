using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class NoticeInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9Ob3RpY2VJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoaQ29tbW9ucy9Ob3RpY2VEQkluZm8ucHJvdG8iQgoSTm90aWNlSW5mb1Jlc3BvbnNlEiwKC25vdGljZV9pbmZvGAEgAygLMhcucHJvdG8ubmV0Lk5vdGljZURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { NoticeDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(NoticeInfoResponse), NoticeInfoResponse.Parser, new string[1] { "NoticeInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
