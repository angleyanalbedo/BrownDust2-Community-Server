using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharPartnerRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0NoYXJQYXJ0bmVyUmV3YXJkUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IlEKGENoYXJQYXJ0bmVyUmV3YXJkUmVxdWVzdBILCgNzZXEYASABKAUSEwoLaW52ZW5faW5kZXgYAiABKAMSEwoLcmV3YXJkX3N0ZXAYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharPartnerRewardRequest), CharPartnerRewardRequest.Parser, new string[3] { "Seq", "InvenIndex", "RewardStep" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
