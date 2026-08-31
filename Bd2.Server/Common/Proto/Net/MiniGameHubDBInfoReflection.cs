using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004655 RID: 18005
	public static class MiniGameHubDBInfoReflection
	{
		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x0601C31D RID: 115485 RVA: 0x007E6C4B File Offset: 0x007E4E4B
		public static FileDescriptor Descriptor
		{
			get
			{
				return MiniGameHubDBInfoReflection.descriptor;
			}
		}

		// Token: 0x040159AA RID: 88490
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL01pbmlHYW1lSHViREJJbmZvLnByb3RvEglwcm90by5uZXQi" + "SwoRTWluaUdhbWVIdWJEQkluZm8SDAoEc2xvdBgBIAEoBRIRCglldmVudF91" + "aWQYAiABKAUSFQoNcHJvZ3Jlc3NfdHlwZRgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MiniGameHubDBInfo), MiniGameHubDBInfo.Parser, new string[] { "Slot", "EventUid", "ProgressType" }, null, null, null, null)
		}));
	}
}
