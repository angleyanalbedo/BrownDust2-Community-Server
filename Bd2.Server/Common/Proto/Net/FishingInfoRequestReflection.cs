using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004AA4 RID: 19108
	public static class FishingInfoRequestReflection
	{
		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x0601EB41 RID: 125761 RVA: 0x00844151 File Offset: 0x00842351
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x04016B2D RID: 92973
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0Zpc2hpbmdJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "IiEKEkZpc2hpbmdJbmZvUmVxdWVzdBILCgNzZXEYASABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingInfoRequest), FishingInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
