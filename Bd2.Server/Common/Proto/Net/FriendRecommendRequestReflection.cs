using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendRecommendRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0ZyaWVuZFJlY29tbWVuZFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCIlChZGcmllbmRSZWNvbW1lbmRSZXF1ZXN0EgsKA3NlcRgBIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendRecommendRequest), FriendRecommendRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
