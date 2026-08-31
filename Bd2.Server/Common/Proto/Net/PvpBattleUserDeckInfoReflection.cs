using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleUserDeckInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL1B2cEJhdHRsZVVzZXJEZWNrSW5mby5wcm90bxIJcHJvdG8u" + "bmV0Ir8BChVQdnBCYXR0bGVVc2VyRGVja0luZm8SGAoQY2hhcl9pbnZlbl9p" + "bmRleBgBIAEoAxIQCghwb3NpdGlvbhgCIAEoBRIQCghzZXF1ZW5jZRgDIAEo" + "BRIbChNjb3N0dW1lX2ludmVuX2luZGV4GAQgASgDEh8KF2Nvc3R1bWVfaW52" + "ZW5faW5kZXhfc2VxGAUgAygDEioKInByaW9yaXR5X3NraWxsX2Nvc3R1bWVf" + "aW52ZW5faW5kZXgYBiADKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleUserDeckInfo), PvpBattleUserDeckInfo.Parser, new string[6] { "CharInvenIndex", "Position", "Sequence", "CostumeInvenIndex", "CostumeInvenIndexSeq", "PrioritySkillCostumeInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
