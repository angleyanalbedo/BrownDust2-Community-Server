using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ItemDumpRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L0l0ZW1EdW1wUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8iSAoPSXRlbUR1bXBSZXF1ZXN0EgsKA3NlcRgBIAEoBRIoCglpdGVtX2luZm8YAiABKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ItemDumpRequest), ItemDumpRequest.Parser, new string[2] { "Seq", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
