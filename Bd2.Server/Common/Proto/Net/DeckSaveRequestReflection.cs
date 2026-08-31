using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class DeckSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L0RlY2tTYXZlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0RlY2tEQkluZm8ucHJvdG8iXAoPRGVja1NhdmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRIoCglkZWNrX2luZm8YAiADKAsyFS5wcm90by5uZXQuRGVja0RCSW5mbxISCgpkZWNrX3Bvd2VyGAMgASgFYgZwcm90bzM="), new FileDescriptor[1] { DeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(DeckSaveRequest), DeckSaveRequest.Parser, new string[3] { "Seq", "DeckInfo", "DeckPower" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
