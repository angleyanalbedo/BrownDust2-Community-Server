using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleRetryPreviousTurnResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXNwb25zZS9CYXR0bGVSZXRyeVByZXZpb3VzVHVyblJlc3BvbnNlLnBy" + "b3RvEglwcm90by5uZXQiqgEKFE1vbnN0ZXJIdW50U2tpbGxEYXRhEhIKCmNv" + "c3R1bWVfaWQYASABKAUSEQoJdXNlX2NvdW50GAIgASgFEhQKDGNvbmRpdGlv" + "bl9pZBgDIAEoBRIWCg5wYXJ0c190YWJsZV9pZBgEIAEoBRI9CgpsaW1pdF90" + "eXBlGAUgASgOMikucHJvdG8ubmV0LkRlZmluZV9FTW9uc3Rlckh1bnRTa2ls" + "bExpbWl0cyKCAQoYTW9uc3Rlckh1bnRUZWFtUHJvdG9JbmZvEhcKD2JsdWVf" + "Y2hhcl9wcm90bxgBIAEoCRIYChBibHVlX2VxdWlwX3Byb3RvGAIgASgJEhcK" + "D2JsdWVfYnVmZl9wcm90bxgDIAEoCRIaChJibHVlX2Nvc3R1bWVfcHJvdG8Y" + "BCABKAkiwwIKH0JhdHRsZVJldHJ5UHJldmlvdXNUdXJuUmVzcG9uc2USFQoN" + "YmF0dGxlX3Jlc3VsdBgBIAEoCRIkChxibHVlX3RlYW1fc2tpbGxfYnViYmxl" + "X2NvdW50GAIgASgFEiMKG3JlZF90ZWFtX3NraWxsX2J1YmJsZV9jb3VudBgD" + "IAEoBRIZChFtb25zdGVyX2h1bnRfdGVhbRgEIAEoBRJDChptb25zdGVyX2h1" + "bnRfc2tpbGxfaGlzdG9yeRgFIAMoCzIfLnByb3RvLm5ldC5Nb25zdGVySHVu" + "dFNraWxsRGF0YRJKCh1tb25zdGVyX2h1bnRfYmVmb3JlX3RlYW1faW5mbxgG" + "IAMoCzIjLnByb3RvLm5ldC5Nb25zdGVySHVudFRlYW1Qcm90b0luZm8SEgoK" + "dHVybl9jb3VudBgHIAEoBSpACh5EZWZpbmVfRU1vbnN0ZXJIdW50U2tpbGxM" + "aW1pdHMSCAoETm9uZRAAEggKBFRlYW0QARIKCgZCYXR0bGUQAmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(Define_EMonsterHuntSkillLimits) }, null, new GeneratedClrTypeInfo[3]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntSkillData), MonsterHuntSkillData.Parser, new string[5] { "CostumeId", "UseCount", "ConditionId", "PartsTableId", "LimitType" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(MonsterHuntTeamProtoInfo), MonsterHuntTeamProtoInfo.Parser, new string[4] { "BlueCharProto", "BlueEquipProto", "BlueBuffProto", "BlueCostumeProto" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(BattleRetryPreviousTurnResponse), BattleRetryPreviousTurnResponse.Parser, new string[7] { "BattleResult", "BlueTeamSkillBubbleCount", "RedTeamSkillBubbleCount", "MonsterHuntTeam", "MonsterHuntSkillHistory", "MonsterHuntBeforeTeamInfo", "TurnCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
