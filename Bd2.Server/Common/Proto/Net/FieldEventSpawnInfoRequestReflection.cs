using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004A47 RID: 19015
	public static class FieldEventSpawnInfoRequestReflection
	{
		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x0601E807 RID: 124935 RVA: 0x0083D7A1 File Offset: 0x0083B9A1
		public static FileDescriptor Descriptor
		{
			get
			{
				return FieldEventSpawnInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x04016A1D RID: 92701
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L0ZpZWxkRXZlbnRTcGF3bkluZm9SZXF1ZXN0LnByb3RvEglw" + "cm90by5uZXQiRAoaRmllbGRFdmVudFNwYXduSW5mb1JlcXVlc3QSCwoDc2Vx" + "GAEgASgFEhkKEWV2ZW50X3NjaGVkdWxlX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FieldEventSpawnInfoRequest), FieldEventSpawnInfoRequest.Parser, new string[] { "Seq", "EventScheduleId" }, null, null, null, null)
		}));
	}
}
