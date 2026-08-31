using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipPresetSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0VxdWlwUHJlc2V0U2F2ZVJlcXVlc3QucHJvdG8SCXByb3Rv" + "Lm5ldCKdAQoWRXF1aXBQcmVzZXRTYXZlUmVxdWVzdBILCgNzZXEYASABKAUS" + "GAoQY2hhcl9pbnZlbl9pbmRleBgCIAEoAxIMCgRzbG90GAMgASgFEhMKC3By" + "ZXNldF9uYW1lGAQgASgJEhoKEnByZXNldF9yZXNvdXJjZV9pZBgFIAEoBRId" + "ChVwcmVzZXRfcmVzb3VyY2VfY29sb3IYBiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipPresetSaveRequest), EquipPresetSaveRequest.Parser, new string[6] { "Seq", "CharInvenIndex", "Slot", "PresetName", "PresetResourceId", "PresetResourceColor" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
