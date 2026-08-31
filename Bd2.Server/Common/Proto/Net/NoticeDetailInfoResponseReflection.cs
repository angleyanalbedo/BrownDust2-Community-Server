using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class NoticeDetailInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9Ob3RpY2VEZXRhaWxJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoaQ29tbW9ucy9Ob3RpY2VEQkluZm8ucHJvdG8iSAoYTm90aWNlRGV0YWlsSW5mb1Jlc3BvbnNlEiwKC25vdGljZV9pbmZvGAEgASgLMhcucHJvdG8ubmV0Lk5vdGljZURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { NoticeDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(NoticeDetailInfoResponse), NoticeDetailInfoResponse.Parser, new string[1] { "NoticeInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
