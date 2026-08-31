using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CharFieldVoiceTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjpjb21tb24uZGIvU291bmRUYWJsZV9fX+yCrOyatOuTnC9DaGFyRmllbGRW" + "b2ljZVRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uImgKE0NoYXJG" + "aWVsZFZvaWNlVGFibGUSFwoPZGFtYWdlVm9pY2VOYW1lGAEgASgJEhUKDWRh" + "c2hWb2ljZU5hbWUYAiABKAkSCgoCaWQYAyABKAUSFQoNbGlmdFZvaWNlTmFt" + "ZRgEIAEoCUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVz" + "aWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharFieldVoiceTable), CharFieldVoiceTable.Parser, new string[4] { "DamageVoiceName", "DashVoiceName", "Id", "LiftVoiceName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
