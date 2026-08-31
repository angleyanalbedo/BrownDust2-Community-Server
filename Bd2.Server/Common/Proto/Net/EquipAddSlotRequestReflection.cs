using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipAddSlotRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L0VxdWlwQWRkU2xvdFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI0ChNFcXVpcEFkZFNsb3RSZXF1ZXN0EgsKA3NlcRgBIAEoBRIQCghhZGRfc2xvdBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipAddSlotRequest), EquipAddSlotRequest.Parser, new string[2] { "Seq", "AddSlot" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
