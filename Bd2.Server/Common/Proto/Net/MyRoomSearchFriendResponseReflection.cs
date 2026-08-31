using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomSearchFriendResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9NeVJvb21TZWFyY2hGcmllbmRSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhxDb21tb25zL015Um9vbVVzZXJJbmZvLnByb3RvIkoKGk15Um9vbVNlYXJjaEZyaWVuZFJlc3BvbnNlEiwKCXJvb21faW5mbxgBIAMoCzIZLnByb3RvLm5ldC5NeVJvb21Vc2VySW5mb2IGcHJvdG8z"), new FileDescriptor[1] { MyRoomUserInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomSearchFriendResponse), MyRoomSearchFriendResponse.Parser, new string[1] { "RoomInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
