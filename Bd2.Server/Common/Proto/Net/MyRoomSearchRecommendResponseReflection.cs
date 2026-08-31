using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomSearchRecommendResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXNwb25zZS9NeVJvb21TZWFyY2hSZWNvbW1lbmRSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhxDb21tb25zL015Um9vbVVzZXJJbmZvLnByb3RvIk0KHU15Um9vbVNlYXJjaFJlY29tbWVuZFJlc3BvbnNlEiwKCXJvb21faW5mbxgBIAMoCzIZLnByb3RvLm5ldC5NeVJvb21Vc2VySW5mb2IGcHJvdG8z"), new FileDescriptor[1] { MyRoomUserInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomSearchRecommendResponse), MyRoomSearchRecommendResponse.Parser, new string[1] { "RoomInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
