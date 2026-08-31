using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntDispatchEndRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0h1bnREaXNwYXRjaEVuZFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJfChZIdW50RGlzcGF0Y2hFbmRSZXF1ZXN0EgsKA3NlcRgBIAEoBRIeChZodW50X2Rpc3BhdGNoX2dyb3VwX2lkGAIgASgFEhgKEGh1bnRfZGlzcGF0Y2hfaWQYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchEndRequest), HuntDispatchEndRequest.Parser, new string[3] { "Seq", "HuntDispatchGroupId", "HuntDispatchId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
