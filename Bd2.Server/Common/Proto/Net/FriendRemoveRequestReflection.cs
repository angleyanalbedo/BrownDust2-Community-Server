using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendRemoveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L0ZyaWVuZFJlbW92ZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI3ChNGcmllbmRSZW1vdmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgtvd25lcl9pbmRleBgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendRemoveRequest), FriendRemoveRequest.Parser, new string[2] { "Seq", "OwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
