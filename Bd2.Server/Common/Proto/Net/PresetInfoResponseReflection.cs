using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PresetInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9QcmVzZXRJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoaQ29tbW9ucy9QcmVzZXREQkluZm8ucHJvdG8iQgoSUHJlc2V0SW5mb1Jlc3BvbnNlEiwKC3ByZXNldF9pbmZvGAEgAygLMhcucHJvdG8ubmV0LlByZXNldERCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { PresetDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PresetInfoResponse), PresetInfoResponse.Parser, new string[1] { "PresetInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
