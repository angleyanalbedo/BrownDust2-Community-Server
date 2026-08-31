using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntDispatchRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L0h1bnREaXNwYXRjaFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJrChNIdW50RGlzcGF0Y2hSZXF1ZXN0EgsKA3NlcRgBIAEoBRIeChZodW50X2Rpc3BhdGNoX2dyb3VwX2lkGAIgASgFEhgKEGh1bnRfZGlzcGF0Y2hfaWQYAyABKAUSDQoFY291bnQYBCABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchRequest), HuntDispatchRequest.Parser, new string[4] { "Seq", "HuntDispatchGroupId", "HuntDispatchId", "Count" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
