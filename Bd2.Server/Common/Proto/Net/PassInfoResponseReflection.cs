using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PassInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9QYXNzSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQa" + "GENvbW1vbnMvUGFzc0RCSW5mby5wcm90bxoeQ29tbW9ucy9QYXNzUmV3YXJk" + "REJJbmZvLnByb3RvInMKEFBhc3NJbmZvUmVzcG9uc2USKAoJcGFzc19pbmZv" + "GAEgAygLMhUucHJvdG8ubmV0LlBhc3NEQkluZm8SNQoQcGFzc19yZXdhcmRf" + "aW5mbxgCIAMoCzIbLnByb3RvLm5ldC5QYXNzUmV3YXJkREJJbmZvYgZwcm90" + "bzM="), new FileDescriptor[2]
	{
		PassDBInfoReflection.Descriptor,
		PassRewardDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassInfoResponse), PassInfoResponse.Parser, new string[2] { "PassInfo", "PassRewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
