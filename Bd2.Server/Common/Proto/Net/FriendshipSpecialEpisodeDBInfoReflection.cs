using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200458E RID: 17806
	public static class FriendshipSpecialEpisodeDBInfoReflection
	{
		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x0601BAC0 RID: 113344 RVA: 0x007CF485 File Offset: 0x007CD685
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeDBInfoReflection.descriptor;
			}
		}

		// Token: 0x040155DE RID: 87518
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixDb21tb25zL0ZyaWVuZHNoaXBTcGVjaWFsRXBpc29kZURCSW5mby5wcm90" + "bxIJcHJvdG8ubmV0Ij4KHkZyaWVuZHNoaXBTcGVjaWFsRXBpc29kZURCSW5m" + "bxIQCghncm91cF9pZBgBIAEoBRIKCgJpZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipSpecialEpisodeDBInfo), FriendshipSpecialEpisodeDBInfo.Parser, new string[] { "GroupId", "Id" }, null, null, null, null)
		}));
	}
}
