using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004637 RID: 17975
	public static class MiniEventHubSlotDBInfoReflection
	{
		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x0601C1D9 RID: 115161 RVA: 0x007E3876 File Offset: 0x007E1A76
		public static FileDescriptor Descriptor
		{
			get
			{
				return MiniEventHubSlotDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015926 RID: 88358
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiRDb21tb25zL01pbmlFdmVudEh1YlNsb3REQkluZm8ucHJvdG8SCXByb3Rv", "Lm5ldCKPAQoWTWluaUV2ZW50SHViU2xvdERCSW5mbxIKCgJpZBgBIAEoBRIY", "ChBodWJfY29udGVudF90eXBlGAIgASgFEhYKDmh1Yl9jb250ZW50X2lkGAMg", "ASgFEhEKCWV2ZW50X3VpZBgEIAEoBRISCgpzdGFydF90aW1lGAUgASgDEhAK", "CGVuZF90aW1lGAYgASgDYgZwcm90bzM=" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MiniEventHubSlotDBInfo), MiniEventHubSlotDBInfo.Parser, new string[] { "Id", "HubContentType", "HubContentId", "EventUid", "StartTime", "EndTime" }, null, null, null, null)
		}));
	}
}
