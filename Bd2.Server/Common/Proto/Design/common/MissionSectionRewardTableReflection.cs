using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MissionSectionRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj9jb21tb24uZGIvTWlzc2lvblRhYmxlX19f66+47IWYL01pc3Npb25TZWN0" + "aW9uUmV3YXJkVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iiwEK" + "GU1pc3Npb25TZWN0aW9uUmV3YXJkVGFibGUSEQoJZ3JvdXBUeXBlGAEgASgF" + "EgoKAmlkGAIgASgFEhMKC3Jld2FyZENvdW50GAMgASgFEhAKCHJld2FyZElk" + "GAQgASgFEhIKCnJld2FyZFR5cGUYBSABKAUSFAoMc2VjdGlvblZhbHVlGAYg" + "ASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24u" + "Y29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MissionSectionRewardTable), MissionSectionRewardTable.Parser, new string[6] { "GroupType", "Id", "RewardCount", "RewardId", "RewardType", "SectionValue" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
