using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L015Um9vbVNhdmVSZXF1ZXN0LnByb3RvEglwcm90by5uZXQaGkNvbW1vbnMvTXlSb29tREJJbmZvLnByb3RvIkwKEU15Um9vbVNhdmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRIqCglyb29tX2luZm8YAiABKAsyFy5wcm90by5uZXQuTXlSb29tREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { MyRoomDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomSaveRequest), MyRoomSaveRequest.Parser, new string[2] { "Seq", "RoomInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
