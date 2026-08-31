using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntingGroundDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL0h1bnRpbmdHcm91bmREQkluZm8ucHJvdG8SCXByb3RvLm5l" + "dBobQ29tbW9ucy9Nb25zdGVyREJJbmZvLnByb3RvIn4KE0h1bnRpbmdHcm91" + "bmREQkluZm8SDwoHaXNfYXV0bxgBIAEoCBISCgpjdXJyZW50X2lkGAIgASgF" + "EhIKCmhpZ2hlc3RfaWQYAyABKAUSLgoMbW9uc3Rlcl9pbmZvGAQgAygLMhgu" + "cHJvdG8ubmV0Lk1vbnN0ZXJEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { MonsterDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntingGroundDBInfo), HuntingGroundDBInfo.Parser, new string[4] { "IsAuto", "CurrentId", "HighestId", "MonsterInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
