using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharPartnerRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9DaGFyUGFydG5lclJld2FyZFJlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaGENvbW1vbnMvSXRlbURCSW5mby5wcm90bxoYQ29tbW9ucy9D" + "aGFyREJJbmZvLnByb3RvGhlDb21tb25zL0VxdWlwREJJbmZvLnByb3RvGhtD" + "b21tb25zL0Nvc3R1bWVEQkluZm8ucHJvdG8i0gEKGUNoYXJQYXJ0bmVyUmV3" + "YXJkUmVzcG9uc2USKAoJaXRlbV9pbmZvGAEgAygLMhUucHJvdG8ubmV0Lkl0" + "ZW1EQkluZm8SLwoQcmV3YXJkX2NoYXJfaW5mbxgCIAMoCzIVLnByb3RvLm5l" + "dC5DaGFyREJJbmZvEioKCmVxdWlwX2luZm8YAyADKAsyFi5wcm90by5uZXQu" + "RXF1aXBEQkluZm8SLgoMY29zdHVtZV9pbmZvGAQgAygLMhgucHJvdG8ubmV0" + "LkNvc3R1bWVEQkluZm9iBnByb3RvMw=="), new FileDescriptor[4]
	{
		ItemDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharPartnerRewardResponse), CharPartnerRewardResponse.Parser, new string[4] { "ItemInfo", "RewardCharInfo", "EquipInfo", "CostumeInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
