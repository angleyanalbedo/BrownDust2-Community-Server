using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostumeUpgradeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0Nvc3R1bWVVcGdyYWRlUmVxdWVzdC5wcm90bxIJcHJvdG8u" + "bmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8iYwoVQ29zdHVtZVVwZ3Jh" + "ZGVSZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgtpbnZlbl9pbmRleBgCIAEoAxIo" + "CglpdGVtX2luZm8YAyADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IGcHJv" + "dG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeUpgradeRequest), CostumeUpgradeRequest.Parser, new string[3] { "Seq", "InvenIndex", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
