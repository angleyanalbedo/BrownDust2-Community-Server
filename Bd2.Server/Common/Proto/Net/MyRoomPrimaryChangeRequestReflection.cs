using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomPrimaryChangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L015Um9vbVByaW1hcnlDaGFuZ2VSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiPAoaTXlSb29tUHJpbWFyeUNoYW5nZVJlcXVlc3QSCwoDc2VxGAEgASgFEhEKCWNoYW5nZV9pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomPrimaryChangeRequest), MyRoomPrimaryChangeRequest.Parser, new string[2] { "Seq", "ChangeId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
