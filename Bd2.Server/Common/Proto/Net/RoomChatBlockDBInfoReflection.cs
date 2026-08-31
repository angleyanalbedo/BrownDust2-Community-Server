using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004751 RID: 18257
	public static class RoomChatBlockDBInfoReflection
	{
		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0601CCD9 RID: 117977 RVA: 0x00801541 File Offset: 0x007FF741
		public static FileDescriptor Descriptor
		{
			get
			{
				return RoomChatBlockDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04016047 RID: 90183
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL1Jvb21DaGF0QmxvY2tEQkluZm8ucHJvdG8SCXByb3RvLm5l" + "dCJdChNSb29tQ2hhdEJsb2NrREJJbmZvEhoKEnRhcmdldF9vd25lcl9pbmRl" + "eBgBIAEoAxIWCg50YXJnZXRfdXNlcl9pZBgCIAEoCRISCgpibG9ja19kYXRl" + "GAMgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RoomChatBlockDBInfo), RoomChatBlockDBInfo.Parser, new string[] { "TargetOwnerIndex", "TargetUserId", "BlockDate" }, null, null, null, null)
		}));
	}
}
