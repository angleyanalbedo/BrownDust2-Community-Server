using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLRelicChoiceTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STFJlbGlj" + "Q2hvaWNlVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iRgoSUkxS" + "ZWxpY0Nob2ljZVRhYmxlEgoKAmlkGAEgASgFEhEKCXJhdGVHcmFkZRgCIAMo" + "BRIRCglyZWxpY1R5cGUYAyABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblAB" + "WhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9u" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLRelicChoiceTable), RLRelicChoiceTable.Parser, new string[3] { "Id", "RateGrade", "RelicType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
