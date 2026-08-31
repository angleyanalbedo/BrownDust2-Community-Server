using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class BattleFieldBuffTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvQmF0dGxlVGFibGVfX1/soITtiKwvQmF0dGxlRmllbGRC" + "dWZmVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iRAoUQmF0dGxl" + "RmllbGRCdWZmVGFibGUSDgoGYnVmZklEGAEgASgFEgoKAmlkGAIgASgFEhAK" + "CHRlYW1UeXBlGAMgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Q" + "cm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleFieldBuffTable), BattleFieldBuffTable.Parser, new string[3] { "BuffID", "Id", "TeamType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
