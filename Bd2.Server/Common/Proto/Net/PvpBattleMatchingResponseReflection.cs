using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleMatchingResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9QdnBCYXR0bGVNYXRjaGluZ1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaI0NvbW1vbnMvUHZwQmF0dGxlVXNlckRlY2tJbmZvLnByb3Rv" + "GhhDb21tb25zL0NoYXJEQkluZm8ucHJvdG8aG0NvbW1vbnMvQ29zdHVtZURC" + "SW5mby5wcm90bxoZQ29tbW9ucy9FcXVpcERCSW5mby5wcm90bxohQ29tbW9u" + "cy9FdmVudFNjaGVkdWxlREJJbmZvLnByb3RvGiVDb21tb25zL1BpY3Rvcmlh" + "bEJ1ZmZTdGF0REJJbmZvLnByb3RvGh1Db21tb25zL0d1aWxkQmFzZURCSW5m" + "by5wcm90bxodQ29tbW9ucy9DaGFyQXdha2VEQkluZm8ucHJvdG8i7QUKGVB2" + "cEJhdHRsZU1hdGNoaW5nUmVzcG9uc2USDwoHdXNlcl92cBgBIAEoBRIRCgl1" + "c2VyX3JhbmsYAiABKAUSPwoTdXNlcl9idWZmX3N0YXRfaW5mbxgDIAMoCzIi" + "LnByb3RvLm5ldC5QaWN0b3JpYWxCdWZmU3RhdERCSW5mbxIZChFlbmVteV9v" + "d25lcl9pbmRleBgEIAEoAxIVCg1lbmVteV91c2VyX2lkGAUgASgJEhEKCWVu" + "ZW15X2V4cBgGIAEoBRIQCghlbmVteV92cBgHIAEoBRISCgplbmVteV9yYW5r" + "GAggASgFEjkKFWVuZW15X2d1aWxkX2Jhc2VfaW5mbxgJIAEoCzIaLnByb3Rv" + "Lm5ldC5HdWlsZEJhc2VEQkluZm8SIQoZZW5lbXlfcG9ydHJhaXRfY29zdHVt" + "ZV9pZBgKIAEoBRI5Cg9lbmVteV9kZWNrX2luZm8YCyADKAsyIC5wcm90by5u" + "ZXQuUHZwQmF0dGxlVXNlckRlY2tJbmZvEi4KD2VuZW15X2NoYXJfaW5mbxgM" + "IAMoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZvEjQKEmVuZW15X2Nvc3R1bWVf" + "aW5mbxgNIAMoCzIYLnByb3RvLm5ldC5Db3N0dW1lREJJbmZvEjAKEGVuZW15" + "X2VxdWlwX2luZm8YDiADKAsyFi5wcm90by5uZXQuRXF1aXBEQkluZm8SGgoS" + "YmF0dGxlX3JhbmRvbV9zZWVkGA8gASgFEjsKE2V2ZW50X3NjaGVkdWxlX2lu" + "Zm8YECABKAsyHi5wcm90by5uZXQuRXZlbnRTY2hlZHVsZURCSW5mbxJAChRl" + "bmVteV9idWZmX3N0YXRfaW5mbxgRIAMoCzIiLnByb3RvLm5ldC5QaWN0b3Jp" + "YWxCdWZmU3RhdERCSW5mbxI0ChBlbmVteV9hd2FrZV9pbmZvGBIgAygLMhou" + "cHJvdG8ubmV0LkNoYXJBd2FrZURCSW5mb2IGcHJvdG8z"), new FileDescriptor[8]
	{
		PvpBattleUserDeckInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor,
		EventScheduleDBInfoReflection.Descriptor,
		PictorialBuffStatDBInfoReflection.Descriptor,
		GuildBaseDBInfoReflection.Descriptor,
		CharAwakeDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleMatchingResponse), PvpBattleMatchingResponse.Parser, new string[18]
		{
			"UserVp", "UserRank", "UserBuffStatInfo", "EnemyOwnerIndex", "EnemyUserId", "EnemyExp", "EnemyVp", "EnemyRank", "EnemyGuildBaseInfo", "EnemyPortraitCostumeId",
			"EnemyDeckInfo", "EnemyCharInfo", "EnemyCostumeInfo", "EnemyEquipInfo", "BattleRandomSeed", "EventScheduleInfo", "EnemyBuffStatInfo", "EnemyAwakeInfo"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
