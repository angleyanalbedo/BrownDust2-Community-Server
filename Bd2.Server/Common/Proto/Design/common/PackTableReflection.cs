using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ciljb21tb24uZGIvUGFja1RhYmxlX19f7YypL1BhY2tUYWJsZS5wcm90bxIT" + "UHJvdG8uRGVzaWduLmNvbW1vbiLFDAoJUGFja1RhYmxlEg0KBWJhZGdlGAEg" + "ASgFEg8KB2JnbU5hbWUYAiABKAkSEgoKYmdtU291bmRJZBgDIAEoBRIbChNi" + "Z21UaXRsZUxvY2FsVGV4dElkGAQgASgFEhMKC2J1bmRsZUxhYmVsGAUgASgJ" + "EhoKEmJ1eURlc2NMb2NhbFRleHRJZBgGIAEoBRIQCghidXlQcmljZRgHIAEo" + "BRIWCg5idXlSZXdhcmRDb3VudBgIIAMoBRITCgtidXlSZXdhcmRJZBgJIAMo" + "BRIVCg1idXlSZXdhcmRUeXBlGAogAygFEg8KB2J1eVR5cGUYCyABKAUSGwoT" + "Y2FzZUJhY2tUZXh0dXJlTmFtZRgMIAEoCRIkChxjYXNlQmFja1RodW1ibmFp" + "bFRleHR1cmVOYW1lGA0gASgJEhsKE2Nhc2VGcm9udFByZWZhYk5hbWUYDiAB" + "KAkSGQoRY29udGVudFR5cGVUZXh0SWQYDyABKAUSEwoLZG9ja2luZ09uY2UY" + "ECABKAUSFwoPZXBpbG9nSW1hZ2VOYW1lGBEgASgJEhkKEWVwaWxvZ0xvY2Fs" + "VGV4dElkGBIgASgFEhMKC2VwaWxvZ3VlQkdNGBMgASgJEhIKCmZpZWxkTWFw" + "SWQYFCADKAUSGwoTZmllbGRNb25zdGVyR3JvdXBJZBgVIAMoBRIaChJmaWVs" + "ZE9iamVjdEdyb3VwSWQYFiADKAUSGAoQZmllbGRUcmFwR3JvdXBJZBgXIAMo" + "BRIKCgJpZBgYIAEoBRIRCglpc05ld1BhY2sYGSABKAUSIQoZaXNTa2lwUGFj" + "a0luc2VydERpcmVjdGlvbhgaIAEoBRIPCgdsb2dUeXBlGBsgASgFEhwKFG1h" + "aW5RdWVzdFJld2FyZENvdW50GBwgAygFEh0KFW1haW5RdWVzdFJld2FyZENv" + "dW50MRgdIAMoBRIdChVtYWluUXVlc3RSZXdhcmRDb3VudDIYHiADKAUSHQoV" + "bWFpblF1ZXN0UmV3YXJkQ291bnQzGB8gAygFEh0KFW1haW5RdWVzdFJld2Fy" + "ZENvdW50NBggIAMoBRIZChFtYWluUXVlc3RSZXdhcmRJZBghIAMoBRIaChJt" + "YWluUXVlc3RSZXdhcmRJZDEYIiADKAUSGgoSbWFpblF1ZXN0UmV3YXJkSWQy" + "GCMgAygFEhoKEm1haW5RdWVzdFJld2FyZElkMxgkIAMoBRIaChJtYWluUXVl" + "c3RSZXdhcmRJZDQYJSADKAUSGwoTbWFpblF1ZXN0UmV3YXJkVHlwZRgmIAMo" + "BRIcChRtYWluUXVlc3RSZXdhcmRUeXBlMRgnIAMoBRIcChRtYWluUXVlc3RS" + "ZXdhcmRUeXBlMhgoIAMoBRIcChRtYWluUXVlc3RSZXdhcmRUeXBlMxgpIAMo" + "BRIcChRtYWluUXVlc3RSZXdhcmRUeXBlNBgqIAMoBRISCgptYXJrZXRDb2Rl" + "GCsgASgFEhIKCm5leHRQYWNrSWQYLCABKAUSGgoScGFja0Rlc2NOYW1lVGV4" + "dElkGC0gASgFEhAKCHBhY2tIaWRlGC4gASgFEh0KFXBhY2tMb2FkaW5nUHJl" + "ZmFiTmFtZRgvIAEoCRIWCg5wYWNrTmFtZVRleHRJZBgwIAEoBRISCgpwYWNr" + "UGVyaW9kGDEgASgFEhcKD3BhY2tQcmV2aWV3TmFtZRgyIAMoCRIdChVwYWNr" + "UHJldmlld1Nwcml0ZU5hbWUYMyADKAkSFgoOcGFja1Nwcml0ZU5hbWUYNCAB" + "KAkSEAoIcGFja1R5cGUYNSABKAUSIAoYcGFja1Vub3BlbmVkUmVzb3VyY2VO" + "YW1lGDYgASgJEhYKDnByaW9yUGFja0luZGV4GDcgASgFEhcKD3Byb2xvZ0lt" + "YWdlTmFtZRg4IAEoCRIZChFwcm9sb2dMb2NhbFRleHRJZBg5IAEoBRITCgtw" + "cm9sb2d1ZUJHTRg6IAEoCRIRCglzYWxlUHJpY2UYOyABKAUSGQoRc3RhcnRQ" + "b3NpdGlvblBhdGgYPCABKAkSEwoLdXNlU2NoZWR1bGUYPSABKAUSGQoRd2F5" + "cG9pbnRQcmljZVR5cGUYPiABKAUSHgoWd2F5cG9pbnRQcmljZVVuaXRDb3Vu" + "dBg/IAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVz" + "aWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackTable), PackTable.Parser, new string[63]
		{
			"Badge", "BgmName", "BgmSoundId", "BgmTitleLocalTextId", "BundleLabel", "BuyDescLocalTextId", "BuyPrice", "BuyRewardCount", "BuyRewardId", "BuyRewardType",
			"BuyType", "CaseBackTextureName", "CaseBackThumbnailTextureName", "CaseFrontPrefabName", "ContentTypeTextId", "DockingOnce", "EpilogImageName", "EpilogLocalTextId", "EpilogueBGM", "FieldMapId",
			"FieldMonsterGroupId", "FieldObjectGroupId", "FieldTrapGroupId", "Id", "IsNewPack", "IsSkipPackInsertDirection", "LogType", "MainQuestRewardCount", "MainQuestRewardCount1", "MainQuestRewardCount2",
			"MainQuestRewardCount3", "MainQuestRewardCount4", "MainQuestRewardId", "MainQuestRewardId1", "MainQuestRewardId2", "MainQuestRewardId3", "MainQuestRewardId4", "MainQuestRewardType", "MainQuestRewardType1", "MainQuestRewardType2",
			"MainQuestRewardType3", "MainQuestRewardType4", "MarketCode", "NextPackId", "PackDescNameTextId", "PackHide", "PackLoadingPrefabName", "PackNameTextId", "PackPeriod", "PackPreviewName",
			"PackPreviewSpriteName", "PackSpriteName", "PackType", "PackUnopenedResourceName", "PriorPackIndex", "PrologImageName", "PrologLocalTextId", "PrologueBGM", "SalePrice", "StartPositionPath",
			"UseSchedule", "WaypointPriceType", "WaypointPriceUnitCount"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
