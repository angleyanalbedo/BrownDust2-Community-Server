using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class BattleDeckTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRjb21tb24uZGIvQmF0dGxlVGFibGVfX1/soITtiKwvQmF0dGxlRGVja1Rh" + "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIuUHCg9CYXR0bGVEZWNr" + "VGFibGUSHgoWYmF0dGxlQ2xlYXJMb2NhbFRleHRJZBgBIAEoBRIdChViYXR0" + "bGVGYWlsTG9jYWxUZXh0SWQYAiABKAUSFwoPYmF0dGxlRmllbGRCdWZmGAMg" + "AygFEhwKFGJvbnVzRXZpbENhc3RsZVBvaW50GAQgAygFEh0KFWJvbnVzUG9p" + "bnRMb2NhbFRleHRJZBgFIAMoBRIlCh1ib251c1BvaW50VGh1bW5haWxMb2Nh" + "bFRleHRJZBgGIAMoBRIWCg5ib251c1BvaW50VHlwZRgHIAMoBRIYChBib251" + "c1BvaW50VmFsdWUxGAggAygFEhgKEGJvbnVzUG9pbnRWYWx1ZTIYCSADKAUS" + "GAoQYm9udXNSZXdhcmRDb3VudBgKIAMoBRIVCg1ib251c1Jld2FyZElkGAsg" + "AygFEhcKD2JvbnVzUmV3YXJkVHlwZRgMIAMoBRIVCg1jaGFsbGVuZ2VUeXBl" + "GA0gASgFEg4KBmNoYXJJZBgOIAMoBRIRCgljbGVhclRpbWUYDyABKAUSEQoJ" + "Y2xlYXJUeXBlGBAgASgFEhYKDmNsZWFyVHlwZVZhbHVlGBEgASgFEhUKDWNv" + "bW1vblNvdW5kSWQYEiABKAUSEQoJY29zdHVtZUlkGBMgAygFEhIKCmNvc3R1" + "bWVJZDIYFCADKAUSFgoOY29zdHVtZVVzZVR5cGUYFSABKAUSEgoKZGFtYWdl" + "UmF0ZRgWIAEoARIdChVkZWF0aFRpbWVTdGFydFR1cm5QdkUYFyABKAUSFAoM" + "ZGlmZmljdWx0eUlkGBggASgFEgsKA2V4cBgZIAEoBRIWCg5mYWlsV2F5UG9p" + "bnRJZBgaIAEoBRIcChRndWlkZVR1dG9yaWFsR3JvdXBJZBgbIAEoBRISCgpo" + "ZWFsdGhSYXRlGBwgASgBEgoKAmlkGB0gASgFEg0KBWxldmVsGB4gAygFEhQK" + "DG1hcFNjZW5lUGF0aBgfIAEoCRIQCghwb3NpdGlvbhggIAMoBRITCgtyZXdh" + "cmRDb3VudBghIAMoBRIQCghyZXdhcmRJZBgiIAMoBRIYChByZXdhcmRTdXBw" + "bHlUeXBlGCMgASgFEhIKCnJld2FyZFR5cGUYJCADKAUSEAoIc2VxdWVuY2UY" + "JSADKAUSGQoRc2ltcGxlVGFsa0dyb3VwSWQYJiABKAUSGQoRc29sdXRpb25U" + "aXBUZXh0SWQYJyABKAUSEgoKdHV0b3JpYWxJZBgoIAEoBRIZChF1c2VCYXR0" + "bGVDb250aW51ZRgpIAEoBRIWCg53b3JsZEJ1ZmZPbk9mZhgqIAEoBUJEQhNQ" + "cm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoC" + "E1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleDeckTable), BattleDeckTable.Parser, new string[42]
		{
			"BattleClearLocalTextId", "BattleFailLocalTextId", "BattleFieldBuff", "BonusEvilCastlePoint", "BonusPointLocalTextId", "BonusPointThumnailLocalTextId", "BonusPointType", "BonusPointValue1", "BonusPointValue2", "BonusRewardCount",
			"BonusRewardId", "BonusRewardType", "ChallengeType", "CharId", "ClearTime", "ClearType", "ClearTypeValue", "CommonSoundId", "CostumeId", "CostumeId2",
			"CostumeUseType", "DamageRate", "DeathTimeStartTurnPvE", "DifficultyId", "Exp", "FailWayPointId", "GuideTutorialGroupId", "HealthRate", "Id", "Level",
			"MapScenePath", "Position", "RewardCount", "RewardId", "RewardSupplyType", "RewardType", "Sequence", "SimpleTalkGroupId", "SolutionTipTextId", "TutorialId",
			"UseBattleContinue", "WorldBuffOnOff"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
