using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackInGameInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9QYWNrSW5HYW1lSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90" + "by5uZXQaGENvbW1vbnMvQ2hhckRCSW5mby5wcm90bxodQ29tbW9ucy9UYWxl" + "bnROcGNEQkluZm8ucHJvdG8aG0NvbW1vbnMvTW9uc3RlckRCSW5mby5wcm90" + "bxogQ29tbW9ucy9UYWxlbnRPYmplY3REQkluZm8ucHJvdG8aHUNvbW1vbnMv" + "RmllbGRCdWZmREJJbmZvLnByb3RvGh5Db21tb25zL1JlcHV0YXRpb25EQklu" + "Zm8ucHJvdG8aG0NvbW1vbnMvTWFwQWN0aXZlSW5mby5wcm90bxohQ29tbW9u" + "cy9IdW50aW5nR3JvdW5kREJJbmZvLnByb3RvGh9Db21tb25zL1RhbGVudFNr" + "aWxsREJJbmZvLnByb3RvGhlDb21tb25zL1F1ZXN0REJJbmZvLnByb3RvGhpD" + "b21tb25zL1N0YXR1ZURCSW5mby5wcm90bxogQ29tbW9ucy9SZXdhcmREQklu" + "Zm9CdW5kbGUucHJvdG8i8wUKFlBhY2tJbkdhbWVJbmZvUmVzcG9uc2USKAoJ" + "Y2hhcl9pbmZvGAEgAygLMhUucHJvdG8ubmV0LkNoYXJEQkluZm8SKgoKcXVl" + "c3RfaW5mbxgCIAMoCzIWLnByb3RvLm5ldC5RdWVzdERCSW5mbxIXCg9jbGVh" + "cl9xdWVzdF9pZHMYAyADKAUSEAoIcG9zaXRpb24YBCABKAkSMwoPdGFsZW50" + "X25wY19pbmZvGAUgAygLMhoucHJvdG8ubmV0LlRhbGVudE5wY0RCSW5mbxIu" + "Cgxtb25zdGVyX2luZm8YBiADKAsyGC5wcm90by5uZXQuTW9uc3RlckRCSW5m" + "bxI5ChJ0YWxlbnRfb2JqZWN0X2luZm8YByADKAsyHS5wcm90by5uZXQuVGFs" + "ZW50T2JqZWN0REJJbmZvEjMKD2ZpZWxkX2J1ZmZfaW5mbxgIIAMoCzIaLnBy" + "b3RvLm5ldC5GaWVsZEJ1ZmZEQkluZm8SNAoPcmVwdXRhdGlvbl9pbmZvGAkg" + "AygLMhsucHJvdG8ubmV0LlJlcHV0YXRpb25EQkluZm8SMQoPbWFwX2FjdGl2" + "ZV9pbmZvGAogAygLMhgucHJvdG8ubmV0Lk1hcEFjdGl2ZUluZm8SGgoScmVz" + "ZWFyY2hfb2JqZWN0X2lkGAsgAygFEjsKE2h1bnRpbmdfZ3JvdW5kX2luZm8Y" + "DCABKAsyHi5wcm90by5uZXQuSHVudGluZ0dyb3VuZERCSW5mbxI3ChF0YWxl" + "bnRfc2tpbGxfaW5mbxgNIAMoCzIcLnByb3RvLm5ldC5UYWxlbnRTa2lsbERC" + "SW5mbxIsCgtzdGF0dWVfaW5mbxgOIAMoCzIXLnByb3RvLm5ldC5TdGF0dWVE" + "QkluZm8SHwoXc3RhdHVlX3Jld2FyZF9vYnRhaW5faWQYDyADKAUSOQoScmV3" + "YXJkX2luZm9fYnVuZGxlGBAgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5m" + "b0J1bmRsZWIGcHJvdG8z"), new FileDescriptor[12]
	{
		CharDBInfoReflection.Descriptor,
		TalentNpcDBInfoReflection.Descriptor,
		MonsterDBInfoReflection.Descriptor,
		TalentObjectDBInfoReflection.Descriptor,
		FieldBuffDBInfoReflection.Descriptor,
		ReputationDBInfoReflection.Descriptor,
		MapActiveInfoReflection.Descriptor,
		HuntingGroundDBInfoReflection.Descriptor,
		TalentSkillDBInfoReflection.Descriptor,
		QuestDBInfoReflection.Descriptor,
		StatueDBInfoReflection.Descriptor,
		RewardDBInfoBundleReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackInGameInfoResponse), PackInGameInfoResponse.Parser, new string[16]
		{
			"CharInfo", "QuestInfo", "ClearQuestIds", "Position", "TalentNpcInfo", "MonsterInfo", "TalentObjectInfo", "FieldBuffInfo", "ReputationInfo", "MapActiveInfo",
			"ResearchObjectId", "HuntingGroundInfo", "TalentSkillInfo", "StatueInfo", "StatueRewardObtainId", "RewardInfoBundle"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
