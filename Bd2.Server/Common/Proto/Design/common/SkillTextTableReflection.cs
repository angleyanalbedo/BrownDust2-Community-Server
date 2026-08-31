using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SkillTextTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL1Nr" + "aWxsVGV4dFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uInoKDlNr" + "aWxsVGV4dFRhYmxlEgoKAmlkGAEgASgFEh8KF25vZGVBZGRUYXJnZXRCdWZm" + "VGV4dElkGAIgAygFEhMKC25vZGVBZGRUZXh0GAMgASgJEhgKEHRhcmdldEJ1" + "ZmZUZXh0SWQYBCADKAUSDAoEdGV4dBgFIAEoCUJEQhNQcm90by5EZXNpZ24u" + "Y29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2ln" + "bi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkillTextTable), SkillTextTable.Parser, new string[5] { "Id", "NodeAddTargetBuffTextId", "NodeAddText", "TargetBuffTextId", "Text" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
