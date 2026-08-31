using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MissionSectionRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitSZXNwb25zZS9NaXNzaW9uU2VjdGlvblJld2FyZFJlc3BvbnNlLnByb3Rv" + "Eglwcm90by5uZXQaGENvbW1vbnMvSXRlbURCSW5mby5wcm90bxoYQ29tbW9u" + "cy9DaGFyREJJbmZvLnByb3RvGhlDb21tb25zL0VxdWlwREJJbmZvLnByb3Rv" + "GhtDb21tb25zL0Nvc3R1bWVEQkluZm8ucHJvdG8i1QEKHE1pc3Npb25TZWN0" + "aW9uUmV3YXJkUmVzcG9uc2USKAoJaXRlbV9pbmZvGAEgAygLMhUucHJvdG8u" + "bmV0Lkl0ZW1EQkluZm8SLwoQcmV3YXJkX2NoYXJfaW5mbxgCIAMoCzIVLnBy" + "b3RvLm5ldC5DaGFyREJJbmZvEi4KDGNvc3R1bWVfaW5mbxgDIAMoCzIYLnBy" + "b3RvLm5ldC5Db3N0dW1lREJJbmZvEioKCmVxdWlwX2luZm8YBCADKAsyFi5w" + "cm90by5uZXQuRXF1aXBEQkluZm9iBnByb3RvMw=="), new FileDescriptor[4]
	{
		ItemDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MissionSectionRewardResponse), MissionSectionRewardResponse.Parser, new string[4] { "ItemInfo", "RewardCharInfo", "CostumeInfo", "EquipInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
