using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020047D1 RID: 18385
	public static class AvatarInfoRequestReflection
	{
		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0601D1EE RID: 119278 RVA: 0x0080E6DC File Offset: 0x0080C8DC
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x0401626E RID: 90734
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L0F2YXRhckluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQi" + "IAoRQXZhdGFySW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarInfoRequest), AvatarInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
