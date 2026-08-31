using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class LikeUserRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L0xpa2VVc2VyUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjoKD0xpa2VVc2VyUmVxdWVzdBILCgNzZXEYASABKAUSGgoSdGFyZ2V0X293bmVyX2luZGV4GAIgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LikeUserRequest), LikeUserRequest.Parser, new string[2] { "Seq", "TargetOwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
