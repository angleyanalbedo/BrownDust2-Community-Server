using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020050B3 RID: 20659
	public static class ColosseumUserInfoResponseReflection
	{
		// Token: 0x1700487D RID: 18557
		// (get) Token: 0x060221A0 RID: 139680 RVA: 0x008BBF2B File Offset: 0x008BA12B
		public static FileDescriptor Descriptor
		{
			get
			{
				return ColosseumUserInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04017E7D RID: 97917
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CihSZXNwb25zZS9Db2xvc3NldW1Vc2VySW5mb1Jlc3BvbnNlLnByb3RvEglw", "cm90by5uZXQaI0NvbW1vbnMvQ29sb3NzZXVtVXNlckJhc2VJbmZvLnByb3Rv", "IsoBChlDb2xvc3NldW1Vc2VySW5mb1Jlc3BvbnNlEg4KBnNlYXNvbhgBIAEo", "BRIWCg5yZWd1bGFyX3NlYXNvbhgCIAEoBRIgChhyYW5rX3RhYmxlX2NoYW5n", "ZV9zZWFzb24YAyABKAUSMwoJYmFzZV9pbmZvGAQgASgLMiAucHJvdG8ubmV0", "LkNvbG9zc2V1bVVzZXJCYXNlSW5mbxIYChBpc19zZWFzb25fcmV3YXJkGAUg", "ASgIEhQKDGFwX2J1eV9jb3VudBgGIAEoBWIGcHJvdG8z" })), new FileDescriptor[] { ColosseumUserBaseInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ColosseumUserInfoResponse), ColosseumUserInfoResponse.Parser, new string[] { "Season", "RegularSeason", "RankTableChangeSeason", "BaseInfo", "IsSeasonReward", "ApBuyCount" }, null, null, null, null)
		}));
	}
}
