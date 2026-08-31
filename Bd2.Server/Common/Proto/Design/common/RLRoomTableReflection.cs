using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLRoomTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STFJvb21U" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLkAQoLUkxSb29tVGFi" + "bGUSFAoMYmF0dGxlRGVja0lkGAEgASgFEhoKEmJhdHRsZVJlY292ZXJ5UmF0" + "ZRgCIAEoARIZChFiYXR0bGVSZXdhcmRQb2ludBgDIAEoBRIaChJjb3N0dW1l" + "Q2hvaWNlQ291bnQYBCABKAUSFQoNZXZlbnRDaG9pY2VJZBgFIAEoBRIPCgdn" + "cm91cElkGAYgASgFEgoKAmlkGAcgASgFEhUKDXJld2FyZFJlbGljSWQYCCAD" + "KAUSEwoLc2hvcFRhYmxlSWQYCSABKAUSDAoEdHlwZRgKIAEoBUJEQhNQcm90" + "by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1By" + "b3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLRoomTable), RLRoomTable.Parser, new string[10] { "BattleDeckId", "BattleRecoveryRate", "BattleRewardPoint", "CostumeChoiceCount", "EventChoiceId", "GroupId", "Id", "RewardRelicId", "ShopTableId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
