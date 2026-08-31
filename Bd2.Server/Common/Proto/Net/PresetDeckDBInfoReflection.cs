using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PresetDeckDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL1ByZXNldERlY2tEQkluZm8ucHJvdG8SCXByb3RvLm5ldBoYQ29tbW9ucy9EZWNrREJJbmZvLnByb3RvIl4KEFByZXNldERlY2tEQkluZm8SLQoOZGVja19iYXNlX2luZm8YASABKAsyFS5wcm90by5uZXQuRGVja0RCSW5mbxIbChNjb3N0dW1lX2ludmVuX2luZGV4GAIgASgDYgZwcm90bzM="), new FileDescriptor[1] { DeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PresetDeckDBInfo), PresetDeckDBInfo.Parser, new string[2] { "DeckBaseInfo", "CostumeInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
