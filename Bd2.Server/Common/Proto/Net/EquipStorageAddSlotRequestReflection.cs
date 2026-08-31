using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipStorageAddSlotRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L0VxdWlwU3RvcmFnZUFkZFNsb3RSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiOwoaRXF1aXBTdG9yYWdlQWRkU2xvdFJlcXVlc3QSCwoDc2VxGAEgASgFEhAKCGFkZF9zbG90GAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipStorageAddSlotRequest), EquipStorageAddSlotRequest.Parser, new string[2] { "Seq", "AddSlot" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
