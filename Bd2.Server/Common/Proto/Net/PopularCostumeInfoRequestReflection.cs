using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PopularCostumeInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L1BvcHVsYXJDb3N0dW1lSW5mb1JlcXVlc3QucHJvdG8SCXBy" + "b3RvLm5ldCKSAQoZUG9wdWxhckNvc3R1bWVJbmZvUmVxdWVzdBILCgNzZXEY" + "ASABKAUSFAoMY29udGVudF90eXBlGAIgASgFEhEKCWRlY2tfdHlwZRgDIAEo" + "BRIWCg5yZXNlcnZlZF9vcmRlchgEIAEoBRIVCg1yYW5rX2dyb3VwX2lkGAUg" + "ASgFEhAKCHN0YWdlX2lkGAYgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PopularCostumeInfoRequest), PopularCostumeInfoRequest.Parser, new string[6] { "Seq", "ContentType", "DeckType", "ReservedOrder", "RankGroupId", "StageId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
