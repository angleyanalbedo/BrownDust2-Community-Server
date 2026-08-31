using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomUserInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L015Um9vbVVzZXJJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0Ik0KFU15Um9vbVVzZXJJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSGgoSdGFyZ2V0X293bmVyX2luZGV4GAIgASgDEgsKA2FsbBgDIAEoCGIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomUserInfoRequest), MyRoomUserInfoRequest.Parser, new string[3] { "Seq", "TargetOwnerIndex", "All" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
