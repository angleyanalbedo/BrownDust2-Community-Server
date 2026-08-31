using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomNameChangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L015Um9vbU5hbWVDaGFuZ2VSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiQAoXTXlSb29tTmFtZUNoYW5nZVJlcXVlc3QSCwoDc2VxGAEgASgFEgoKAmlkGAIgASgFEgwKBG5hbWUYAyABKAliBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomNameChangeRequest), MyRoomNameChangeRequest.Parser, new string[3] { "Seq", "Id", "Name" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
