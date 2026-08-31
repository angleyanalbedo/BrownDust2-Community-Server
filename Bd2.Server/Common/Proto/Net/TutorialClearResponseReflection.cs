using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TutorialClearResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9UdXRvcmlhbENsZWFyUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCIXChVUdXRvcmlhbENsZWFyUmVzcG9uc2ViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TutorialClearResponse), TutorialClearResponse.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
