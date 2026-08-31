using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PresetDeleteRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L1ByZXNldERlbGV0ZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCIwChNQcmVzZXREZWxldGVSZXF1ZXN0EgsKA3NlcRgBIAEoBRIMCgRzbG90GAIgAygFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PresetDeleteRequest), PresetDeleteRequest.Parser, new string[2] { "Seq", "Slot" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
