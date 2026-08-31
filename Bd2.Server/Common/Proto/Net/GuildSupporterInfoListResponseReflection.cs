using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildSupporterInfoListResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXNwb25zZS9HdWlsZFN1cHBvcnRlckluZm9MaXN0UmVzcG9uc2UucHJv" + "dG8SCXByb3RvLm5ldBogQ29tbW9ucy9HdWlsZFN1cHBvcnRlckluZm8ucHJv" + "dG8iVwoeR3VpbGRTdXBwb3J0ZXJJbmZvTGlzdFJlc3BvbnNlEjUKDnN1cHBv" + "cnRlcl9pbmZvGAEgAygLMh0ucHJvdG8ubmV0Lkd1aWxkU3VwcG9ydGVySW5m" + "b2IGcHJvdG8z"), new FileDescriptor[1] { GuildSupporterInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildSupporterInfoListResponse), GuildSupporterInfoListResponse.Parser, new string[1] { "SupporterInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
