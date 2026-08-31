using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007CAB RID: 31915
	public static class FishingTimeTableReflection
	{
		// Token: 0x1701127A RID: 70266
		// (get) Token: 0x06046DA6 RID: 290214 RVA: 0x0113A5EB File Offset: 0x011387EB
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingTimeTableReflection.descriptor;
			}
		}

		// Token: 0x0402EB84 RID: 191364
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjFjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nVGltZVRhYmxl", "LnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIkkKEEZpc2hpbmdUaW1lVGFi", "bGUSCgoCaWQYASABKAUSEQoJc3RhcnRUaW1lGAIgASgJEhYKDnRpbWVOYW1l", "VGV4dElkGAMgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90", "by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingTimeTable), FishingTimeTable.Parser, new string[] { "Id", "StartTime", "TimeNameTextId" }, null, null, null, null)
		}));
	}
}
