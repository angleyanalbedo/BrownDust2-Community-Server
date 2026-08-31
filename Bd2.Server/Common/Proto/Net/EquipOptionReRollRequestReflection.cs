using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipOptionReRollRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0VxdWlwT3B0aW9uUmVSb2xsUmVxdWVzdC5wcm90bxIJcHJv" + "dG8ubmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8inAEKGEVxdWlwT3B0" + "aW9uUmVSb2xsUmVxdWVzdBILCgNzZXEYASABKAUSGQoRZXF1aXBfaW52ZW5f" + "aW5kZXgYAiABKAMSFQoNbWFpbl9vcHRfbG9jaxgDIAMoCBIUCgxzdWJfb3B0" + "X2xvY2sYBCADKAgSKwoMY29uc3VtZV9pdGVtGAUgAygLMhUucHJvdG8ubmV0" + "Lkl0ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipOptionReRollRequest), EquipOptionReRollRequest.Parser, new string[5] { "Seq", "EquipInvenIndex", "MainOptLock", "SubOptLock", "ConsumeItem" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
