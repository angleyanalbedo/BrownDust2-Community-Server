using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildSupporterInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL0d1aWxkU3VwcG9ydGVySW5mby5wcm90bxIJcHJvdG8ubmV0" + "GhhDb21tb25zL0NoYXJEQkluZm8ucHJvdG8aG0NvbW1vbnMvQ29zdHVtZURC" + "SW5mby5wcm90bxoZQ29tbW9ucy9FcXVpcERCSW5mby5wcm90bxodQ29tbW9u" + "cy9DaGFyQXdha2VEQkluZm8ucHJvdG8i1AEKHEd1aWxkU3VwcG9ydGVyQmF0" + "dGxlQ2hhckluZm8SKAoJY2hhcl9pbmZvGAEgASgLMhUucHJvdG8ubmV0LkNo" + "YXJEQkluZm8SLgoMY29zdHVtZV9pbmZvGAIgAygLMhgucHJvdG8ubmV0LkNv" + "c3R1bWVEQkluZm8SKgoKZXF1aXBfaW5mbxgDIAMoCzIWLnByb3RvLm5ldC5F" + "cXVpcERCSW5mbxIuCgphd2FrZV9pbmZvGAQgASgLMhoucHJvdG8ubmV0LkNo" + "YXJBd2FrZURCSW5mbyKLAQoSR3VpbGRTdXBwb3J0ZXJJbmZvEhMKC293bmVy" + "X2luZGV4GAEgASgDEhIKCnNsb3RfaW5kZXgYAiABKAUSDwoHdXNlcl9pZBgD" + "IAEoCRIYChBiYXR0bGVfdXNlX2NvdW50GAQgASgFEiEKGXN1cHBvcnRlcl9j" + "aGFyX2luZm9fcHJvdG8YBSABKAliBnByb3RvMw=="), new FileDescriptor[4]
	{
		CharDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor,
		CharAwakeDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(GuildSupporterBattleCharInfo), GuildSupporterBattleCharInfo.Parser, new string[4] { "CharInfo", "CostumeInfo", "EquipInfo", "AwakeInfo" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(GuildSupporterInfo), GuildSupporterInfo.Parser, new string[5] { "OwnerIndex", "SlotIndex", "UserId", "BattleUseCount", "SupporterCharInfoProto" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
