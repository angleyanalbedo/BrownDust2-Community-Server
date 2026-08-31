using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020048F4 RID: 18676
	public static class ColosseumUserInfoRequestReflection
	{
		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0601DC0C RID: 121868 RVA: 0x00823828 File Offset: 0x00821A28
		public static FileDescriptor Descriptor
		{
			get
			{
				return ColosseumUserInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x040165DC RID: 91612
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0NvbG9zc2V1bVVzZXJJbmZvUmVxdWVzdC5wcm90bxIJcHJv" + "dG8ubmV0IicKGENvbG9zc2V1bVVzZXJJbmZvUmVxdWVzdBILCgNzZXEYASAB" + "KAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ColosseumUserInfoRequest), ColosseumUserInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
