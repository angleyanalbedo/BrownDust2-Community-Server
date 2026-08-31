using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class TextDescriptionTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjpjb21tb24uZGIvVGV4dFRhYmxlX19f7YWN7Iqk7Yq4L1RleHREZXNjcmlw" + "dGlvblRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIlYKFFRleHRE" + "ZXNjcmlwdGlvblRhYmxlEhcKD2Rlc2NTa2lsbFRleHRJZBgBIAEoBRIKCgJp" + "ZBgCIAEoBRIZChF0YXJnZXRTa2lsbFRleHRJZBgDIAEoBUJEQhNQcm90by5E" + "ZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3Rv" + "LkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TextDescriptionTable), TextDescriptionTable.Parser, new string[3] { "DescSkillTextId", "Id", "TargetSkillTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
