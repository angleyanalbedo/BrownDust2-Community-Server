using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipPresetNameChangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXF1ZXN0L0VxdWlwUHJlc2V0TmFtZUNoYW5nZVJlcXVlc3QucHJvdG8S" + "CXByb3RvLm5ldCKjAQocRXF1aXBQcmVzZXROYW1lQ2hhbmdlUmVxdWVzdBIL" + "CgNzZXEYASABKAUSGAoQY2hhcl9pbnZlbl9pbmRleBgCIAEoAxIMCgRzbG90" + "GAMgASgFEhMKC3ByZXNldF9uYW1lGAQgASgJEhoKEnByZXNldF9yZXNvdXJj" + "ZV9pZBgFIAEoBRIdChVwcmVzZXRfcmVzb3VyY2VfY29sb3IYBiABKAViBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipPresetNameChangeRequest), EquipPresetNameChangeRequest.Parser, new string[6] { "Seq", "CharInvenIndex", "Slot", "PresetName", "PresetResourceId", "PresetResourceColor" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
