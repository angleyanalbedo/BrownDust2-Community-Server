using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UserContentsInfoOptionResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXNwb25zZS9Vc2VyQ29udGVudHNJbmZvT3B0aW9uUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCJJCh5Vc2VyQ29udGVudHNJbmZvT3B0aW9uUmVzcG9uc2USFgoOaXNfYWxsX3ByaXZhdGUYASABKAgSDwoHb3B0aW9ucxgCIAMoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserContentsInfoOptionResponse), UserContentsInfoOptionResponse.Parser, new string[2] { "IsAllPrivate", "Options" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
