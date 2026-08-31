using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomUserInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9NeVJvb21Vc2VySW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaHENvbW1vbnMvTXlSb29tVXNlckluZm8ucHJvdG8iRgoWTXlSb29tVXNlckluZm9SZXNwb25zZRIsCglyb29tX2luZm8YASABKAsyGS5wcm90by5uZXQuTXlSb29tVXNlckluZm9iBnByb3RvMw=="), new FileDescriptor[1] { MyRoomUserInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomUserInfoResponse), MyRoomUserInfoResponse.Parser, new string[1] { "RoomInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
