using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CharGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0No" + "YXJHcm91cFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIlsKDkNo" + "YXJHcm91cFRhYmxlEg4KBmNoYXJJZBgBIAEoBRIPCgdncm91cElkGAIgASgF" + "EgoKAmlkGAMgASgFEg0KBWlzQmFuGAQgASgFEg0KBWxldmVsGAUgASgFQkRC" + "E1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9u" + "qgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharGroupTable), CharGroupTable.Parser, new string[5] { "CharId", "GroupId", "Id", "IsBan", "Level" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
