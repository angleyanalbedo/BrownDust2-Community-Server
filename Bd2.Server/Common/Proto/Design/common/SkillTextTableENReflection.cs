using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SkillTextTableENReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkBjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL1Nr" + "aWxsVGV4dFRhYmxlX0VOLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIn0K" + "EVNraWxsVGV4dFRhYmxlX0VOEgoKAmlkGAEgASgFEh8KF25vZGVBZGRUYXJn" + "ZXRCdWZmVGV4dElkGAIgAygFEhMKC25vZGVBZGRUZXh0GAMgASgJEhgKEHRh" + "cmdldEJ1ZmZUZXh0SWQYBCADKAUSDAoEdGV4dBgFIAEoCUJEQhNQcm90by5E" + "ZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3Rv" + "LkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkillTextTable_EN), SkillTextTable_EN.Parser, new string[5] { "Id", "NodeAddTargetBuffTextId", "NodeAddText", "TargetBuffTextId", "Text" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
