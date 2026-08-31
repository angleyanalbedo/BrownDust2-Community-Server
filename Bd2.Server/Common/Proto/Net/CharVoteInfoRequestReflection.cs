using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004896 RID: 18582
	public static class CharVoteInfoRequestReflection
	{
		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0601D8D0 RID: 121040 RVA: 0x0081CF3F File Offset: 0x0081B13F
		public static FileDescriptor Descriptor
		{
			get
			{
				return CharVoteInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x040164CE RID: 91342
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L0NoYXJWb3RlSW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5l" + "dCIiChNDaGFyVm90ZUluZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CharVoteInfoRequest), CharVoteInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
