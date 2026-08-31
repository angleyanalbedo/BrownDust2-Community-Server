using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PresetDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb21tb25zL1ByZXNldERCSW5mby5wcm90bxIJcHJvdG8ubmV0Gh5Db21t" + "b25zL1ByZXNldERlY2tEQkluZm8ucHJvdG8inAEKDFByZXNldERCSW5mbxIT" + "CgtwcmVzZXRfbmFtZRgBIAEoCRIaChJwcmVzZXRfcmVzb3VyY2VfaWQYAiAB" + "KAUSHQoVcHJlc2V0X3Jlc291cmNlX2NvbG9yGAMgASgFEgwKBHNsb3QYBCAB" + "KAUSLgoJZGVja19pbmZvGAUgAygLMhsucHJvdG8ubmV0LlByZXNldERlY2tE" + "QkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { PresetDeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PresetDBInfo), PresetDBInfo.Parser, new string[5] { "PresetName", "PresetResourceId", "PresetResourceColor", "Slot", "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
