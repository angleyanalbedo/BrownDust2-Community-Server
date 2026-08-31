using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendSearchResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9GcmllbmRTZWFyY2hSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhpDb21tb25zL0ZyaWVuZERCSW5mby5wcm90byJEChRGcmllbmRTZWFyY2hSZXNwb25zZRIsCgtmcmllbmRfaW5mbxgBIAEoCzIXLnByb3RvLm5ldC5GcmllbmREQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { FriendDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendSearchResponse), FriendSearchResponse.Parser, new string[1] { "FriendInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
