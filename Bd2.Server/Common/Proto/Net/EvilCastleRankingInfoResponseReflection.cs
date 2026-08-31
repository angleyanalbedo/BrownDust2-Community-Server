using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRankingInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXNwb25zZS9FdmlsQ2FzdGxlUmFua2luZ0luZm9SZXNwb25zZS5wcm90" + "bxIJcHJvdG8ubmV0GiRDb21tb25zL0V2aWxDYXN0bGVSYW5rVXNlckluZm8u" + "cHJvdG8imQEKHUV2aWxDYXN0bGVSYW5raW5nSW5mb1Jlc3BvbnNlEjwKEXVz" + "ZXJfcmFua2luZ19pbmZvGAEgAygLMiEucHJvdG8ubmV0LkV2aWxDYXN0bGVS" + "YW5rVXNlckluZm8SOgoPbXlfcmFua2luZ19pbmZvGAIgASgLMiEucHJvdG8u" + "bmV0LkV2aWxDYXN0bGVSYW5rVXNlckluZm9iBnByb3RvMw=="), new FileDescriptor[1] { EvilCastleRankUserInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRankingInfoResponse), EvilCastleRankingInfoResponse.Parser, new string[2] { "UserRankingInfo", "MyRankingInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
