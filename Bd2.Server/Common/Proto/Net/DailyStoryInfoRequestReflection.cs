using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004928 RID: 18728
	public static class DailyStoryInfoRequestReflection
	{
		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x0601DDF1 RID: 122353 RVA: 0x00827C43 File Offset: 0x00825E43
		public static FileDescriptor Descriptor
		{
			get
			{
				return DailyStoryInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x04016691 RID: 91793
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0RhaWx5U3RvcnlJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8u" + "bmV0IiQKFURhaWx5U3RvcnlJbmZvUmVxdWVzdBILCgNzZXEYASABKAViBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DailyStoryInfoRequest), DailyStoryInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
