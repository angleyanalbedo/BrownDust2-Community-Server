using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class RefreshTokenRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L1JlZnJlc2hUb2tlblJlcXVlc3QucHJvdG8SCXByb3RvLm5ldBoVQ29tbW9ucy9FbnZJbmZvLnByb3RvIl4KE1JlZnJlc2hUb2tlblJlcXVlc3QSCwoDc2VxGAEgASgFEiQKCGVudl9pbmZvGAIgASgLMhIucHJvdG8ubmV0LkVudkluZm8SFAoMYWNjZXNzX3Rva2VuGAMgASgJYgZwcm90bzM="), new FileDescriptor[1] { EnvInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RefreshTokenRequest), RefreshTokenRequest.Parser, new string[3] { "Seq", "EnvInfo", "AccessToken" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
