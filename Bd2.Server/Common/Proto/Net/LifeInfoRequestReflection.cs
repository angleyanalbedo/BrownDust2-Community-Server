using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004C44 RID: 19524
	public static class LifeInfoRequestReflection
	{
		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x0601F987 RID: 129415 RVA: 0x00861820 File Offset: 0x0085FA20
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x04016FD8 RID: 94168
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L0xpZmVJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0Ih4K" + "D0xpZmVJbmZvUmVxdWVzdBILCgNzZXEYASABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeInfoRequest), LifeInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
