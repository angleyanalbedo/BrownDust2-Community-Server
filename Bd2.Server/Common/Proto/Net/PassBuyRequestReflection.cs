using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PassBuyRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSZXF1ZXN0L1Bhc3NCdXlSZXF1ZXN0LnByb3RvEglwcm90by5uZXQaFENvbW1vbnMvRGVmaW5lLnByb3RvImQKDlBhc3NCdXlSZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYXNzX2lkGAIgASgFEjQKDXBhc3NfYnV5X3R5cGUYAyABKA4yHS5wcm90by5uZXQuRGVmaW5lX1Bhc3NCdXlUeXBlYgZwcm90bzM="), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassBuyRequest), PassBuyRequest.Parser, new string[3] { "Seq", "PassId", "PassBuyType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
