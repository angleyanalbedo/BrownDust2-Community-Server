using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomItemInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9NeVJvb21JdGVtSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaIENvbW1vbnMvTXlSb29tVHJvcGh5REJJbmZvLnByb3RvIkwKFk15Um9vbUl0ZW1JbmZvUmVzcG9uc2USMgoLdHJvcGh5X2luZm8YASADKAsyHS5wcm90by5uZXQuTXlSb29tVHJvcGh5REJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { MyRoomTrophyDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomItemInfoResponse), MyRoomItemInfoResponse.Parser, new string[1] { "TrophyInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
