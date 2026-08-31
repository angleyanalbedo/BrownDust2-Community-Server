using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004757 RID: 18263
	public static class RoomChatReportUserDBInfoReflection
	{
		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0601CD11 RID: 118033 RVA: 0x00801D2A File Offset: 0x007FFF2A
		public static FileDescriptor Descriptor
		{
			get
			{
				return RoomChatReportUserDBInfoReflection.descriptor;
			}
		}

		// Token: 0x0401605B RID: 90203
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZDb21tb25zL1Jvb21DaGF0UmVwb3J0VXNlckRCSW5mby5wcm90bxIJcHJv" + "dG8ubmV0IlEKGFJvb21DaGF0UmVwb3J0VXNlckRCSW5mbxIUCgxyZXBvcnRf" + "Y291bnQYASABKAUSHwoXcmVwb3J0X2NvdW50X3Jlc2V0X3RpbWUYAiABKANi" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RoomChatReportUserDBInfo), RoomChatReportUserDBInfo.Parser, new string[] { "ReportCount", "ReportCountResetTime" }, null, null, null, null)
		}));
	}
}
