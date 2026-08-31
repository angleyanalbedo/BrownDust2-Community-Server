using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MyRoomDefaultTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvTXlSb29tX19f66eI7J2066O4L015Um9vbURlZmF1bHRU" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiK/AQoSTXlSb29tRGVm" + "YXVsdFRhYmxlEhgKEGNhcnBldExpbWl0Q291bnQYASABKAUSFgoOY2hhckxp" + "bWl0Q291bnQYAiABKAUSCgoCaWQYAyABKAUSGAoQb2JqZWN0TGltaXRDb3Vu" + "dBgEIAEoBRIcChRvdGhlclBsYXllckxpc3RDb3VudBgFIAEoBRIaChJwcmVz" + "ZXRNYXhTbG90Q291bnQYBiABKAUSFwoPcHJlc2V0U2xvdENvdW50GAcgASgF" + "QkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29t" + "bW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomDefaultTable), MyRoomDefaultTable.Parser, new string[7] { "CarpetLimitCount", "CharLimitCount", "Id", "ObjectLimitCount", "OtherPlayerListCount", "PresetMaxSlotCount", "PresetSlotCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
