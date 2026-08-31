using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005454 RID: 21588
	public static class MasterTitleInfoResponseReflection
	{
		// Token: 0x17004FC6 RID: 20422
		// (get) Token: 0x06024074 RID: 147572 RVA: 0x008FE623 File Offset: 0x008FC823
		public static FileDescriptor Descriptor
		{
			get
			{
				return MasterTitleInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04018905 RID: 100613
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9NYXN0ZXJUaXRsZUluZm9SZXNwb25zZS5wcm90bxIJcHJv" + "dG8ubmV0IkMKF01hc3RlclRpdGxlSW5mb1Jlc3BvbnNlEgwKBG5hbWUYASAB" + "KAkSDQoFbW9udGgYAiABKAUSCwoDZGF5GAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MasterTitleInfoResponse), MasterTitleInfoResponse.Parser, new string[] { "Name", "Month", "Day" }, null, null, null, null)
		}));
	}
}
