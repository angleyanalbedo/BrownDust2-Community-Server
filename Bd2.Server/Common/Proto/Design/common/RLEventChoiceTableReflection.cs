using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLEventChoiceTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STEV2ZW50" + "Q2hvaWNlVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iNgoSUkxF" + "dmVudENob2ljZVRhYmxlEhQKDGV2ZW50R3JvdXBJZBgBIAMoBRIKCgJpZBgC" + "IAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWdu" + "LmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLEventChoiceTable), RLEventChoiceTable.Parser, new string[2] { "EventGroupId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
