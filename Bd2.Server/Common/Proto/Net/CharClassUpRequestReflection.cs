using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharClassUpRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0NoYXJDbGFzc1VwUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8iaQoSQ2hhckNsYXNzVXBSZXF1" + "ZXN0EgsKA3NlcRgBIAEoBRITCgtpbnZlbl9pbmRleBgCIAEoAxIxChJpdGVt" + "X21hdGVyaWFsX2luZm8YAyADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IG" + "cHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharClassUpRequest), CharClassUpRequest.Parser, new string[3] { "Seq", "InvenIndex", "ItemMaterialInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
