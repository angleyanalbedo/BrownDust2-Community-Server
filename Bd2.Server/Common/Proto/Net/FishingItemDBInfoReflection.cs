using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004576 RID: 17782
	public static class FishingItemDBInfoReflection
	{
		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x0601B9CC RID: 113100 RVA: 0x007CCD7B File Offset: 0x007CAF7B
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingItemDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015579 RID: 87417
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0Zpc2hpbmdJdGVtREJJbmZvLnByb3RvEglwcm90by5uZXQi" + "ZQoRRmlzaGluZ0l0ZW1EQkluZm8SEwoLaW52ZW5faW5kZXgYASABKAMSCgoC" + "aWQYAiABKAUSDAoEdHlwZRgDIAEoBRINCgVjb3VudBgEIAEoBRISCgp0aW1l" + "X3ZhbHVlGAUgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingItemDBInfo), FishingItemDBInfo.Parser, new string[] { "InvenIndex", "Id", "Type", "Count", "TimeValue" }, null, null, null, null)
		}));
	}
}
