using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CostumeTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0Nv" + "c3R1bWVUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLbBQoMQ29z" + "dHVtZVRhYmxlEhYKDmF0dGFja01vdmVUeXBlGAEgASgFEhMKC2F0dGFja1Jh" + "bmdlGAIgASgFEhgKEGF0dGFja1JhbmdlQ291bnQYAyABKAUSEgoKYXR0YWNr" + "VHlwZRgEIAEoBRIZChFidWZmSW1tdW5lR3JvdXBJRBgFIAEoBRIdChVjb3N0" + "dW1lRGVzY05hbWVUZXh0SWQYBiABKAUSFwoPY29zdHVtZURlc2lnbklkGAcg" + "ASgFEhUKDWNvc3R1bWVEaWFsb2cYCCABKAUSGQoRY29zdHVtZU5hbWVUZXh0" + "SWQYCSABKAUSFQoNZ3Jvd3RoR3JvdXBJZBgKIAEoBRIKCgJpZBgLIAEoBRIV" + "Cg1pdGVtQWNxdWlyZUlkGAwgAygFEi0KJWphcGFuZXNlQ2hhcmFjdGVyVm9p" + "Y2VBY3Rvck5hbWVUZXh0SWQYDSABKAUSKwoja29yZWFuQ2hhcmFjdGVyVm9p" + "Y2VBY3Rvck5hbWVUZXh0SWQYDiABKAUSEAoIbWF4TGV2ZWwYDyABKAUSGgoS" + "bm9yU3ViQXR0YWNrQnVmZklkGBAgASgFEiMKG25vclN1YkF0dGFja0Rlc2NT" + "a2lsbFRleHRJZBgRIAEoBRIjChtub3JTdWJBdHRhY2tOYW1lU2tpbGxUZXh0" + "SWQYEiABKAUSIwobbm9ybWFsQXR0YWNrRGVzY1NraWxsVGV4dElkGBMgASgF" + "EiMKG25vcm1hbEF0dGFja05hbWVTa2lsbFRleHRJZBgUIAEoBRIQCghub3RU" + "cmFzaBgVIAEoBRIOCgZwYWNrSWQYFiABKAUSFAoMc2tpbGxHcm91cElkGBcg" + "ASgFEhgKEHNwQXR0YWNrQWRkQ291bnQYGCABKAUSEgoKdGFyZ2V0VHlwZRgZ" + "IAEoBRIUCgx1c2VSb2d1ZWxpa2UYGiABKAUSFwoPdXNlVW5pcXVlQ2hhcklk" + "GBsgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNp" + "Z24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeTable), CostumeTable.Parser, new string[27]
		{
			"AttackMoveType", "AttackRange", "AttackRangeCount", "AttackType", "BuffImmuneGroupID", "CostumeDescNameTextId", "CostumeDesignId", "CostumeDialog", "CostumeNameTextId", "GrowthGroupId",
			"Id", "ItemAcquireId", "JapaneseCharacterVoiceActorNameTextId", "KoreanCharacterVoiceActorNameTextId", "MaxLevel", "NorSubAttackBuffId", "NorSubAttackDescSkillTextId", "NorSubAttackNameSkillTextId", "NormalAttackDescSkillTextId", "NormalAttackNameSkillTextId",
			"NotTrash", "PackId", "SkillGroupId", "SpAttackAddCount", "TargetType", "UseRoguelike", "UseUniqueCharId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
