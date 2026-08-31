using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleHistoryResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9QdnBCYXR0bGVIaXN0b3J5UmVzcG9uc2UucHJvdG8SCXBy" + "b3RvLm5ldBoiQ29tbW9ucy9QdnBCYXR0bGVIaXN0b3J5SW5mby5wcm90byLb" + "BQoYUHZwQmF0dGxlSGlzdG9yeVJlc3BvbnNlEjwKE2F0dGFja19oaXN0b3J5" + "X2luZm8YASADKAsyHy5wcm90by5uZXQuUHZwQmF0dGxlSGlzdG9yeUluZm8S" + "PQoUZGVmZW5zZV9oaXN0b3J5X2luZm8YAiADKAsyHy5wcm90by5uZXQuUHZw" + "QmF0dGxlSGlzdG9yeUluZm8SGAoQc2Vhc29uX3dpbl9jb3VudBgDIAEoBRIZ" + "ChFzZWFzb25fbG9zZV9jb3VudBgEIAEoBRIfChdzZWFzb25fYXR0YWNrX3dp" + "bl9jb3VudBgFIAEoBRIgChhzZWFzb25fYXR0YWNrX2xvc2VfY291bnQYBiAB" + "KAUSIAoYc2Vhc29uX2RlZmVuc2Vfd2luX2NvdW50GAcgASgFEiEKGXNlYXNv" + "bl9kZWZlbnNlX2xvc2VfY291bnQYCCABKAUSJAoccHJldl9zZWFzb25fYXR0" + "YWNrX3dpbl9jb3VudBgJIAEoBRIlCh1wcmV2X3NlYXNvbl9hdHRhY2tfbG9z" + "ZV9jb3VudBgKIAEoBRIlCh1wcmV2X3NlYXNvbl9kZWZlbnNlX3dpbl9jb3Vu" + "dBgLIAEoBRImCh5wcmV2X3NlYXNvbl9kZWZlbnNlX2xvc2VfY291bnQYDCAB" + "KAUSJAocZGVja19zZWFzb25fYXR0YWNrX3dpbl9jb3VudBgNIAEoBRIlCh1k" + "ZWNrX3NlYXNvbl9hdHRhY2tfbG9zZV9jb3VudBgOIAEoBRIlCh1kZWNrX3Nl" + "YXNvbl9kZWZlbnNlX3dpbl9jb3VudBgPIAEoBRImCh5kZWNrX3NlYXNvbl9k" + "ZWZlbnNlX2xvc2VfY291bnQYECABKAUSJQodZGVja19zZWFzb25fYXR0YWNr" + "X3Jlc2V0X2RhdGUYESABKAMSJgoeZGVja19zZWFzb25fZGVmZW5zZV9yZXNl" + "dF9kYXRlGBIgASgDYgZwcm90bzM="), new FileDescriptor[1] { PvpBattleHistoryInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleHistoryResponse), PvpBattleHistoryResponse.Parser, new string[18]
		{
			"AttackHistoryInfo", "DefenseHistoryInfo", "SeasonWinCount", "SeasonLoseCount", "SeasonAttackWinCount", "SeasonAttackLoseCount", "SeasonDefenseWinCount", "SeasonDefenseLoseCount", "PrevSeasonAttackWinCount", "PrevSeasonAttackLoseCount",
			"PrevSeasonDefenseWinCount", "PrevSeasonDefenseLoseCount", "DeckSeasonAttackWinCount", "DeckSeasonAttackLoseCount", "DeckSeasonDefenseWinCount", "DeckSeasonDefenseLoseCount", "DeckSeasonAttackResetDate", "DeckSeasonDefenseResetDate"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
