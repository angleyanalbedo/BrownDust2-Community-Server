using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendSendRemoveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L0ZyaWVuZFNlbmRSZW1vdmVSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiOwoXRnJpZW5kU2VuZFJlbW92ZVJlcXVlc3QSCwoDc2VxGAEgASgFEhMKC293bmVyX2luZGV4GAIgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendSendRemoveRequest), FriendSendRemoveRequest.Parser, new string[2] { "Seq", "OwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
