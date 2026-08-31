using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SquadExpTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvU3F1YWRMZXZlbFRhYmxlX19f67aA64yA66CI67KoL1Nx" + "dWFkRXhwVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iKAoNU3F1" + "YWRFeHBUYWJsZRILCgNFWFAYASABKAUSCgoCaWQYAiABKAVCREITUHJvdG8u" + "RGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90" + "by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SquadExpTable), SquadExpTable.Parser, new string[2] { "EXP", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
