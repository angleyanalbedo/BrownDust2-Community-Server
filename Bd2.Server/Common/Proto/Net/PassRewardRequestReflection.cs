using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PassRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L1Bhc3NSZXdhcmRSZXF1ZXN0LnByb3RvEglwcm90by5uZXQa" + "FENvbW1vbnMvRGVmaW5lLnByb3RvIoQBChFQYXNzUmV3YXJkUmVxdWVzdBIL" + "CgNzZXEYASABKAUSDgoGaXNfYWxsGAIgASgIEg8KB3Bhc3NfaWQYAyABKAUS" + "CgoCaWQYBCABKAUSNQoLcmV3YXJkX3R5cGUYBSABKA4yIC5wcm90by5uZXQu" + "RGVmaW5lX1Bhc3NSZXdhcmRUeXBlYgZwcm90bzM="), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassRewardRequest), PassRewardRequest.Parser, new string[5] { "Seq", "IsAll", "PassId", "Id", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
