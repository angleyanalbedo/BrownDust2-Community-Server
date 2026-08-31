using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyLikeInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9NeUxpa2VJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCIwChJNeUxpa2VJbmZvUmVzcG9uc2USGgoSdGFyZ2V0X293bmVyX2luZGV4GAEgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyLikeInfoResponse), MyLikeInfoResponse.Parser, new string[1] { "TargetOwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
