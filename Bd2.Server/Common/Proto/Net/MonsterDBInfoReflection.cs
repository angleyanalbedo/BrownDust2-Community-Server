using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDb21tb25zL01vbnN0ZXJEQkluZm8ucHJvdG8SCXByb3RvLm5ldCKMAQoN" + "TW9uc3RlckRCSW5mbxISCgptb25zdGVyX2lkGAEgASgFEhMKC2JhdHRsZV9k" + "ZWNrGAIgASgFEhQKDHJlc3Bhd25fdGltZRgDIAEoAxIVCg1saWZlX2VuZF90" + "aW1lGAQgASgDEhAKCGdyb3VwX2lkGAUgASgFEhMKC2FjdGl2ZV9mbGFnGAYg" + "ASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterDBInfo), MonsterDBInfo.Parser, new string[6] { "MonsterId", "BattleDeck", "RespawnTime", "LifeEndTime", "GroupId", "ActiveFlag" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
