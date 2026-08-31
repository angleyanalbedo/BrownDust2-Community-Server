using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class DispatchRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0Rpc3BhdGNoUmV3YXJkUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjkKFURpc3BhdGNoUmV3YXJkUmVxdWVzdBILCgNzZXEYASABKAUSEwoLZGlzcGF0Y2hfaWQYAiADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(DispatchRewardRequest), DispatchRewardRequest.Parser, new string[2] { "Seq", "DispatchId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
