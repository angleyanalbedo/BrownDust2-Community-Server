using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldMonsterEventResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9GaWVsZE1vbnN0ZXJFdmVudFJlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaGENvbW1vbnMvQ2hhckRCSW5mby5wcm90bxobQ29tbW9ucy9N" + "b25zdGVyREJJbmZvLnByb3RvGhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8a" + "GUNvbW1vbnMvRXF1aXBEQkluZm8ucHJvdG8iywEKGUZpZWxkTW9uc3RlckV2" + "ZW50UmVzcG9uc2USKAoJY2hhcl9pbmZvGAEgAygLMhUucHJvdG8ubmV0LkNo" + "YXJEQkluZm8SLgoMbW9uc3Rlcl9pbmZvGAIgASgLMhgucHJvdG8ubmV0Lk1v" + "bnN0ZXJEQkluZm8SKAoJaXRlbV9pbmZvGAMgAygLMhUucHJvdG8ubmV0Lkl0" + "ZW1EQkluZm8SKgoKZXF1aXBfaW5mbxgEIAMoCzIWLnByb3RvLm5ldC5FcXVp" + "cERCSW5mb2IGcHJvdG8z"), new FileDescriptor[4]
	{
		CharDBInfoReflection.Descriptor,
		MonsterDBInfoReflection.Descriptor,
		ItemDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMonsterEventResponse), FieldMonsterEventResponse.Parser, new string[4] { "CharInfo", "MonsterInfo", "ItemInfo", "EquipInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
