using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004C9D RID: 19613
	public static class MiniEventHubInfoRequestReflection
	{
		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x0601FCB5 RID: 130229 RVA: 0x00868E14 File Offset: 0x00867014
		public static FileDescriptor Descriptor
		{
			get
			{
				return MiniEventHubInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x04017103 RID: 94467
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L01pbmlFdmVudEh1YkluZm9SZXF1ZXN0LnByb3RvEglwcm90" + "by5uZXQiJgoXTWluaUV2ZW50SHViSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgF" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MiniEventHubInfoRequest), MiniEventHubInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
