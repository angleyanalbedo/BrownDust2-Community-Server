using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class InvenAddSlotRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L0ludmVuQWRkU2xvdFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI0ChNJbnZlbkFkZFNsb3RSZXF1ZXN0EgsKA3NlcRgBIAEoBRIQCghhZGRfc2xvdBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(InvenAddSlotRequest), InvenAddSlotRequest.Parser, new string[2] { "Seq", "AddSlot" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
