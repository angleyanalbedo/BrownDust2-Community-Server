using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200492E RID: 18734
	public static class DatingInfoRequestReflection
	{
		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x0601DE25 RID: 122405 RVA: 0x00828276 File Offset: 0x00826476
		public static FileDescriptor Descriptor
		{
			get
			{
				return DatingInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x040166A1 RID: 91809
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L0RhdGluZ0luZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQi" + "IAoRRGF0aW5nSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DatingInfoRequest), DatingInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
