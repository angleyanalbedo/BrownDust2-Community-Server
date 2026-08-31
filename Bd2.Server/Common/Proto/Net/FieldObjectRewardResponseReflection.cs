using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9GaWVsZE9iamVjdFJld2FyZFJlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvGhhD" + "b21tb25zL0NoYXJEQkluZm8ucHJvdG8aHUNvbW1vbnMvRmllbGRCdWZmREJJ" + "bmZvLnByb3RvGhtDb21tb25zL01vbnN0ZXJEQkluZm8ucHJvdG8i5QEKGUZp" + "ZWxkT2JqZWN0UmV3YXJkUmVzcG9uc2USOQoScmV3YXJkX2luZm9fYnVuZGxl" + "GAEgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1bmRsZRIzCg9maWVs" + "ZF9idWZmX2luZm8YAiADKAsyGi5wcm90by5uZXQuRmllbGRCdWZmREJJbmZv" + "EigKCWNoYXJfaW5mbxgDIAMoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZvEi4K" + "DG1vbnN0ZXJfaW5mbxgEIAEoCzIYLnByb3RvLm5ldC5Nb25zdGVyREJJbmZv" + "YgZwcm90bzM="), new FileDescriptor[4]
	{
		RewardDBInfoBundleReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		FieldBuffDBInfoReflection.Descriptor,
		MonsterDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectRewardResponse), FieldObjectRewardResponse.Parser, new string[4] { "RewardInfoBundle", "FieldBuffInfo", "CharInfo", "MonsterInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
