using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendAcceptRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L0ZyaWVuZEFjY2VwdFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI3ChNGcmllbmRBY2NlcHRSZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgtvd25lcl9pbmRleBgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendAcceptRequest), FriendAcceptRequest.Parser, new string[2] { "Seq", "OwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
