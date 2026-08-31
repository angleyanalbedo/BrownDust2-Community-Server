using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EvilCastleTimeAttackTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj9jb21tb24uZGIvRXZpbENhc3RsZV9f7JWF66eI7ISxL0V2aWxDYXN0bGVU" + "aW1lQXR0YWNrVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iqQIK" + "GUV2aWxDYXN0bGVUaW1lQXR0YWNrVGFibGUSEwoLRGVkdWN0UG9pbnQYASAB" + "KAUSEgoKRGVkdWN0VGltZRgCIAEoBRIUCgxEZWZhdWx0UG9pbnQYAyABKAUS" + "EgoKTGltaXRQb2ludBgEIAEoBRIaChJiYXR0bGVEZWZhdWx0UG9pbnQYBSAB" + "KAUSFwoPYm9zc0V4dHJhUG9pbnRzGAYgASgBEhYKDmRhbWFnZUFkZFBvaW50" + "GAcgASgFEhYKDmRhbWFnZU1heExpbWl0GAggASgFEgoKAmlkGAkgASgFEhgK" + "EHJldHJ5RGVkdWN0UG9pbnQYCiABKAUSGAoQc3Vydml2YWxBZGRQb2ludBgL" + "IAEoBRIUCgx0dXJuQWRkUG9pbnQYDCABKAVCREITUHJvdG8uRGVzaWduLmNv" + "bW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24u" + "Y29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleTimeAttackTable), EvilCastleTimeAttackTable.Parser, new string[12]
		{
			"DeductPoint", "DeductTime", "DefaultPoint", "LimitPoint", "BattleDefaultPoint", "BossExtraPoints", "DamageAddPoint", "DamageMaxLimit", "Id", "RetryDeductPoint",
			"SurvivalAddPoint", "TurnAddPoint"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
