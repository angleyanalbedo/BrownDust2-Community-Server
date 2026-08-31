using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005637 RID: 22071
	public static class RoomChatReportAndBlockInfoResponseReflection
	{
		// Token: 0x170053C0 RID: 21440
		// (get) Token: 0x060250B8 RID: 151736 RVA: 0x0092380C File Offset: 0x00921A0C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RoomChatReportAndBlockInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04018F0D RID: 102157
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjFSZXNwb25zZS9Sb29tQ2hhdFJlcG9ydEFuZEJsb2NrSW5mb1Jlc3BvbnNl", "LnByb3RvEglwcm90by5uZXQaIUNvbW1vbnMvUm9vbUNoYXRCbG9ja0RCSW5m", "by5wcm90bxomQ29tbW9ucy9Sb29tQ2hhdFJlcG9ydFVzZXJEQkluZm8ucHJv", "dG8aI0NvbW1vbnMvUm9vbUNoYXRQZW5hbHR5REJJbmZvLnByb3RvItQBCiJS", "b29tQ2hhdFJlcG9ydEFuZEJsb2NrSW5mb1Jlc3BvbnNlEjcKD2NoYXRfYmxv", "Y2tfaW5mbxgBIAMoCzIeLnByb3RvLm5ldC5Sb29tQ2hhdEJsb2NrREJJbmZv", "Ej0KEHJlcG9ydF91c2VyX2luZm8YAiABKAsyIy5wcm90by5uZXQuUm9vbUNo", "YXRSZXBvcnRVc2VyREJJbmZvEjYKDHBlbmFsdHlfaW5mbxgDIAEoCzIgLnBy", "b3RvLm5ldC5Sb29tQ2hhdFBlbmFsdHlEQkluZm9iBnByb3RvMw==" })), new FileDescriptor[]
		{
			RoomChatBlockDBInfoReflection.Descriptor,
			RoomChatReportUserDBInfoReflection.Descriptor,
			RoomChatPenaltyDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RoomChatReportAndBlockInfoResponse), RoomChatReportAndBlockInfoResponse.Parser, new string[] { "ChatBlockInfo", "ReportUserInfo", "PenaltyInfo" }, null, null, null, null)
		}));
	}
}
