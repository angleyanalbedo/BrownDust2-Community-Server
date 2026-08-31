using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharPartnerStoryRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXNwb25zZS9DaGFyUGFydG5lclN0b3J5UmV3YXJkUmVzcG9uc2UucHJv" + "dG8SCXByb3RvLm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvGhhDb21t" + "b25zL0NoYXJEQkluZm8ucHJvdG8aGUNvbW1vbnMvRXF1aXBEQkluZm8ucHJv" + "dG8aG0NvbW1vbnMvQ29zdHVtZURCSW5mby5wcm90byLXAQoeQ2hhclBhcnRu" + "ZXJTdG9yeVJld2FyZFJlc3BvbnNlEigKCWl0ZW1faW5mbxgBIAMoCzIVLnBy" + "b3RvLm5ldC5JdGVtREJJbmZvEi8KEHJld2FyZF9jaGFyX2luZm8YAiADKAsy" + "FS5wcm90by5uZXQuQ2hhckRCSW5mbxIqCgplcXVpcF9pbmZvGAMgAygLMhYu" + "cHJvdG8ubmV0LkVxdWlwREJJbmZvEi4KDGNvc3R1bWVfaW5mbxgEIAMoCzIY" + "LnByb3RvLm5ldC5Db3N0dW1lREJJbmZvYgZwcm90bzM="), new FileDescriptor[4]
	{
		ItemDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharPartnerStoryRewardResponse), CharPartnerStoryRewardResponse.Parser, new string[4] { "ItemInfo", "RewardCharInfo", "EquipInfo", "CostumeInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
