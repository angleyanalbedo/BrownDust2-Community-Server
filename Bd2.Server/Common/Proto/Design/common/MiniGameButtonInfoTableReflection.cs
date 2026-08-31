using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MiniGameButtonInfoTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9NaW5pR2FtZUJ1" + "dHRvbkluZm9UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiI5ChdN" + "aW5pR2FtZUJ1dHRvbkluZm9UYWJsZRISCgpidXR0b25JbmZvGAEgASgJEgoK" + "AmlkGAIgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5E" + "ZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameButtonInfoTable), MiniGameButtonInfoTable.Parser, new string[2] { "ButtonInfo", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
