using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharLevelUpRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0NoYXJMZXZlbFVwUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8iZgoSQ2hhckxldmVsVXBSZXF1" + "ZXN0EgsKA3NlcRgBIAEoBRITCgtpbnZlbl9pbmRleBgCIAEoAxIuCg9ob2x5" + "X3dhdGVyX2luZm8YAyADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IGcHJv" + "dG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharLevelUpRequest), CharLevelUpRequest.Parser, new string[3] { "Seq", "InvenIndex", "HolyWaterInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
