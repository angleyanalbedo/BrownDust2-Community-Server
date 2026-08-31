using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleTowerDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL0V2aWxDYXN0bGVUb3dlckRCSW5mby5wcm90bxIJcHJvdG8ubmV0IlgKFUV2aWxDYXN0bGVUb3dlckRCSW5mbxIKCgJpZBgBIAEoBRIeChZiYXR0bGVfY2hhbGxlbmdlX2luZGV4GAIgAygFEhMKC2JhdHRsZV9tb2RlGAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleTowerDBInfo), EvilCastleTowerDBInfo.Parser, new string[3] { "Id", "BattleChallengeIndex", "BattleMode" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
