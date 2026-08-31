using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004815 RID: 18453
	public static class CafeteriaInfoRequestReflection
	{
		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0601D45B RID: 119899 RVA: 0x00813DA6 File Offset: 0x00811FA6
		public static FileDescriptor Descriptor
		{
			get
			{
				return CafeteriaInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x04016354 RID: 90964
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L0NhZmV0ZXJpYUluZm9SZXF1ZXN0LnByb3RvEglwcm90by5u" + "ZXQiIwoUQ2FmZXRlcmlhSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CafeteriaInfoRequest), CafeteriaInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
