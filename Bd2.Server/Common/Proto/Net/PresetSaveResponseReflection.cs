using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PresetSaveResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9QcmVzZXRTYXZlUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCIUChJQcmVzZXRTYXZlUmVzcG9uc2ViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PresetSaveResponse), PresetSaveResponse.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
