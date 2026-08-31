using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.pack;

public static class FieldMonsterTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjxwYWNrMS5kYi9GaWVsZFRhYmxlX19fX1/tlYTrk5zsmpTshowvRmllbGRN" + "b25zdGVyVGFibGUucHJvdG8SElByb3RvLkRlc2lnbi5wYWNrMSKxBQoRRmll" + "bGRNb25zdGVyVGFibGUSFAoMYW5pbWF0b3JUeXBlGAEgASgFEhQKDGJhdHRs" + "ZURlY2tJZBgCIAMoBRISCgpidW5kbGVUeXBlGAMgASgFEhUKDWRhbWFnZWRF" + "ZmZlY3QYBCABKAkSFQoNZGlyZWN0aW9uVHlwZRgFIAEoBRITCgtmaWVsZEJ1" + "ZmZJZBgGIAEoBRIYChBmaWVsZE1vbnN0ZXJBSUlkGAcgASgFEhcKD2ZpZWxk" + "UG9pbnRQb3NJZBgIIAEoBRIKCgJocBgJIAEoBRIKCgJpZBgKIAEoBRISCgpp" + "ZGxlRWZmZWN0GAsgASgJEh4KFmludGVyYWN0aW9uTG9jYWxUZXh0SWQYDCAB" + "KAUSHQoVaW50ZXJhY3Rpb25TcHJpdGVOYW1lGA0gASgJEhkKEWlzQXV0b0lu" + "dGVyYWN0aW9uGA4gASgFEhgKEG1vbnN0ZXJDcmFzaFR5cGUYDyABKAUSGQoR" + "bW9uc3RlcklsbHVzdE5hbWUYECABKAkSGQoRbW9uc3Rlck5hbWVUZXh0SWQY" + "ESABKAUSEwoLbW9uc3RlclNpemUYEiABKAUSHgoWbW9uc3RlclRhbGtTdG9y" + "eVRleHRJZBgTIAEoBRIXCg9tb25zdGVyVGltZUxpbmUYFCABKAkSEgoKcXVl" + "c3RSYW5nZRgVIAMoBRIRCglyYW5nZVR5cGUYFiABKAUSDwoHcmVnZW5JZBgX" + "IAEoBRIUCgxyZXNvdXJjZU5hbWUYGCABKAkSFAoMcmVzb3VyY2VUeXBlGBkg" + "ASgFEhMKC3Jld2FyZENvdW50GBogASgFEhAKCHJld2FyZElkGBsgASgFEhIK" + "CnJld2FyZFR5cGUYHCABKAUSDAoEdHlwZRgdIAEoBRIVCg11c2VCYXR0bGVT" + "a2lwGB4gASgFQkFCElByb3RvLkRlc2lnbi5wYWNrMVABWhQuL1Byb3RvLkRl" + "c2lnbi5wYWNrMaoCElByb3RvLkRlc2lnbi5wYWNrMWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMonsterTable), FieldMonsterTable.Parser, new string[30]
		{
			"AnimatorType", "BattleDeckId", "BundleType", "DamagedEffect", "DirectionType", "FieldBuffId", "FieldMonsterAIId", "FieldPointPosId", "Hp", "Id",
			"IdleEffect", "InteractionLocalTextId", "InteractionSpriteName", "IsAutoInteraction", "MonsterCrashType", "MonsterIllustName", "MonsterNameTextId", "MonsterSize", "MonsterTalkStoryTextId", "MonsterTimeLine",
			"QuestRange", "RangeType", "RegenId", "ResourceName", "ResourceType", "RewardCount", "RewardId", "RewardType", "Type", "UseBattleSkip"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
