using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200483F RID: 18495
	public static class CashBonusInfoRequestReflection
	{
		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0601D5B7 RID: 120247 RVA: 0x008163C9 File Offset: 0x008145C9
		public static FileDescriptor Descriptor
		{
			get
			{
				return CashBonusInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x040163B4 RID: 91060
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L0Nhc2hCb251c0luZm9SZXF1ZXN0LnByb3RvEglwcm90by5u" + "ZXQiIwoUQ2FzaEJvbnVzSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CashBonusInfoRequest), CashBonusInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
