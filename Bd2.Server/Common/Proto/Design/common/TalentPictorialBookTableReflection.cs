using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class TalentPictorialBookTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj9jb21tb24uZGIvUGljdG9yaWFsQm9va19fX+uPhOqwkC9UYWxlbnRQaWN0" + "b3JpYWxCb29rVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iYAoY" + "VGFsZW50UGljdG9yaWFsQm9va1RhYmxlEgoKAmlkGAEgASgFEhAKCHRhbGVu" + "dElkGAIgAygFEiYKHnRhbGVudFBpY3RvcmlhbERlc2NMb2NhbFRleHRJZBgD" + "IAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWdu" + "LmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentPictorialBookTable), TalentPictorialBookTable.Parser, new string[3] { "Id", "TalentId", "TalentPictorialDescLocalTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
