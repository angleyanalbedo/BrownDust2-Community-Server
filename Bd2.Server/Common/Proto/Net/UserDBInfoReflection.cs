using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UserDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb21tb25zL1VzZXJEQkluZm8ucHJvdG8SCXByb3RvLm5ldBohQ29tbW9u" + "cy9QdXJjaGFzZUNvdW50REJJbmZvLnByb3RvGh5Db21tb25zL09wdGltaXpl" + "QmFzZUluZm8ucHJvdG8aFENvbW1vbnMvRGVmaW5lLnByb3RvIsQICgpVc2Vy" + "REJJbmZvEhMKC293bmVyX2luZGV4GAEgASgDEg8KB3VzZXJfaWQYAiABKAkS" + "EAoIdXNlcl9rZXkYAyABKAkSGQoRbGFzdF9wbGF5X3BhY2tfaWQYBCABKAUS" + "EgoKaW52ZW5fc2xvdBgFIAEoBRIUCgxzdG9yYWdlX3Nsb3QYBiABKAUSDAoE" + "Z29sZBgHIAEoAxIUCgxmcmVlX2pld2VscnkYCCABKAMSDwoHamV3ZWxyeRgJ" + "IAEoAxISCgplcXVpcF9zbG90GAogASgFEhAKCGNhdGFseXN0GAsgASgDEgsK" + "A2V4cBgMIAEoBRIUCgxsZXZlbF9yZXdhcmQYDSABKAUSGwoTcG9ydHJhaXRf" + "Y29zdHVtZV9pZBgOIAEoBRIaChJlcXVpcF9zdG9yYWdlX3Nsb3QYDyABKAUS" + "EgoKcHZwX3RpY2tldBgQIAEoBRINCgVtZWRhbBgRIAEoBRIYChBldmlsX2Nh" + "c3RsZV9jb2luGBIgASgFEhEKCXVzZXJfdHlwZRgTIAEoBRIXCg9mcmVlX2h1" + "bnRpbmdfYXAYFCABKAUSGAoQYm9udXNfaHVudGluZ19hcBgVIAEoBRIYChBw" + "dnBfdGlja2V0X3N0YWNrGBYgASgFEg8KB21pbGVhZ2UYFyABKAUSEwoLaG9w" + "ZV9wb3dkZXIYGCABKAUSEgoKdW5yZWdfZGF0ZRgZIAEoAxI7ChNwdXJjaGFz" + "ZV9jb3VudF9pbmZvGBogAygLMh4ucHJvdG8ubmV0LlB1cmNoYXNlQ291bnRE" + "QkluZm8SFgoOaXNfZmlyc3RfZ2FjaGEYGyABKAgSEwoLcHJlc2V0X3Nsb3QY" + "HCABKAUSMgoNb3B0aW1pemVfaW5mbxgdIAMoCzIbLnByb3RvLm5ldC5PcHRp" + "bWl6ZUJhc2VJbmZvEhIKCmJsb2NrX2RhdGUYHiABKAMSHgoWcmV0dXJuX3N0" + "YXR1c19lbmRfdGltZRgfIAEoAxIUCgxteV9yb29tX3Nsb3QYICABKAUSHQoV" + "dG90YWxfd2FyX3ByZXNldF9zbG90GCEgASgFEhUKDWV2ZW50X2FwX2ZyZWUY" + "IiABKAUSFgoOZXZlbnRfYXBfc3RhY2sYIyABKAUSGwoTZnJlZV90b3JjaF9s" + "aWdodF9hcBgkIAEoBRIWCg50b3JjaF9saWdodF9hcBglIAEoBRIRCglqb2lu" + "X3RpbWUYJiABKAMSGAoQbmV3YmllX3Bhc3Nfc3RlcBgnIAEoBRI3CgxibG9j" + "a19yZWFzb24YKCABKA4yIS5wcm90by5uZXQuRGVmaW5lX1VzZXJCbG9ja1Jl" + "YXNvbhIVCg1yb2d1ZV9saWtlX2FwGCkgASgFEhsKE3JvZ3VlX2xpa2VfYXBf" + "c3RhY2sYKiABKAUSEgoKbG9naW5fZGF0ZRgrIAEoAxISCgpndWlsZF9jb2lu" + "GCwgASgDYgZwcm90bzM="), new FileDescriptor[3]
	{
		PurchaseCountDBInfoReflection.Descriptor,
		OptimizeBaseInfoReflection.Descriptor,
		DefineReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserDBInfo), UserDBInfo.Parser, new string[44]
		{
			"OwnerIndex", "UserId", "UserKey", "LastPlayPackId", "InvenSlot", "StorageSlot", "Gold", "FreeJewelry", "Jewelry", "EquipSlot",
			"Catalyst", "Exp", "LevelReward", "PortraitCostumeId", "EquipStorageSlot", "PvpTicket", "Medal", "EvilCastleCoin", "UserType", "FreeHuntingAp",
			"BonusHuntingAp", "PvpTicketStack", "Mileage", "HopePowder", "UnregDate", "PurchaseCountInfo", "IsFirstGacha", "PresetSlot", "OptimizeInfo", "BlockDate",
			"ReturnStatusEndTime", "MyRoomSlot", "TotalWarPresetSlot", "EventApFree", "EventApStack", "FreeTorchLightAp", "TorchLightAp", "JoinTime", "NewbiePassStep", "BlockReason",
			"RogueLikeAp", "RogueLikeApStack", "LoginDate", "GuildCoin"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
