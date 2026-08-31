using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005057 RID: 20567
	public static class CharVoteInfoResponseReflection
	{
		// Token: 0x170047B0 RID: 18352
		// (get) Token: 0x06021E6D RID: 138861 RVA: 0x008B47E0 File Offset: 0x008B29E0
		public static FileDescriptor Descriptor
		{
			get
			{
				return CharVoteInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04017D45 RID: 97605
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNSZXNwb25zZS9DaGFyVm90ZUluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8u", "bmV0GiBDb21tb25zL0NoYXJWb3RlVXNlckRCSW5mby5wcm90bxonQ29tbW9u", "cy9DaGFyVm90ZUNvdW50UmV3YXJkREJJbmZvLnByb3RvIu0CChRDaGFyVm90", "ZUluZm9SZXNwb25zZRIVCg1jdXJyZW50X3JvdW5kGAEgASgFEhQKDGNhbmRp", "ZGF0ZV9pZBgCIAMoBRIwCgl2b3RlX2luZm8YAyADKAsyHS5wcm90by5uZXQu", "Q2hhclZvdGVVc2VyREJJbmZvEjkKC3Jld2FyZF9pbmZvGAQgAygLMiQucHJv", "dG8ubmV0LkNoYXJWb3RlQ291bnRSZXdhcmREQkluZm8SHQoVZmF2b3JpdGVf", "Y2FuZGlkYXRlX2lkGAUgAygFEiAKGG5vcm1hbF92b3RlX2NhbmRpZGF0ZV9p", "ZBgGIAMoBRIdChVuZXh0X2RhaWx5X3Jlc2V0X3RpbWUYByABKAMSFgoOaXNf", "ZGFpbHlfcmVzZXQYCCABKAgSQwoTcm91bmRfc2NoZWR1bGVfaW5mbxgJIAMo",
			"CzImLnByb3RvLm5ldC5DaGFyVm90ZVJvdW5kU2NoZWR1bGVEQkluZm8iUgob", "Q2hhclZvdGVSb3VuZFNjaGVkdWxlREJJbmZvEg0KBXJvdW5kGAEgASgFEhIK", "CnN0YXJ0X3RpbWUYAiABKAMSEAoIZW5kX3RpbWUYAyABKANiBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			CharVoteUserDBInfoReflection.Descriptor,
			CharVoteCountRewardDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CharVoteInfoResponse), CharVoteInfoResponse.Parser, new string[] { "CurrentRound", "CandidateId", "VoteInfo", "RewardInfo", "FavoriteCandidateId", "NormalVoteCandidateId", "NextDailyResetTime", "IsDailyReset", "RoundScheduleInfo" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(CharVoteRoundScheduleDBInfo), CharVoteRoundScheduleDBInfo.Parser, new string[] { "Round", "StartTime", "EndTime" }, null, null, null, null)
		}));
	}
}
