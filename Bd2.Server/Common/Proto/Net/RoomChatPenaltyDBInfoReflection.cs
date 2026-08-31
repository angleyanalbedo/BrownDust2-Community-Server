using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004754 RID: 18260
	public static class RoomChatPenaltyDBInfoReflection
	{
		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0601CCF5 RID: 118005 RVA: 0x0080194E File Offset: 0x007FFB4E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RoomChatPenaltyDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04016051 RID: 90193
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL1Jvb21DaGF0UGVuYWx0eURCSW5mby5wcm90bxIJcHJvdG8u" + "bmV0IlAKFVJvb21DaGF0UGVuYWx0eURCSW5mbxISCgpzdGFydF90aW1lGAEg" + "ASgDEhAKCGVuZF90aW1lGAIgASgDEhEKCXJlcG9ydF9pZBgDIAEoBWIGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RoomChatPenaltyDBInfo), RoomChatPenaltyDBInfo.Parser, new string[] { "StartTime", "EndTime", "ReportId" }, null, null, null, null)
		}));
	}
}
