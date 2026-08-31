using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004CEA RID: 19690
	public static class MiniGameHubInfoRequestReflection
	{
		// Token: 0x17004018 RID: 16408
		// (get) Token: 0x0601FFA1 RID: 130977 RVA: 0x0086FAC6 File Offset: 0x0086DCC6
		public static FileDescriptor Descriptor
		{
			get
			{
				return MiniGameHubInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x04017221 RID: 94753
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L01pbmlHYW1lSHViSW5mb1JlcXVlc3QucHJvdG8SCXByb3Rv" + "Lm5ldCIlChZNaW5pR2FtZUh1YkluZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBWIG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MiniGameHubInfoRequest), MiniGameHubInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
