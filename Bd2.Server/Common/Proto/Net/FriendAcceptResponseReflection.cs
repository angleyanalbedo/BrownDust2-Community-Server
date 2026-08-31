using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendAcceptResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9GcmllbmRBY2NlcHRSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhpDb21tb25zL0ZyaWVuZERCSW5mby5wcm90byJEChRGcmllbmRBY2NlcHRSZXNwb25zZRIsCgtmcmllbmRfaW5mbxgBIAEoCzIXLnByb3RvLm5ldC5GcmllbmREQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { FriendDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendAcceptResponse), FriendAcceptResponse.Parser, new string[1] { "FriendInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
