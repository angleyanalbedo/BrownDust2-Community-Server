using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200456D RID: 17773
	public static class FishingFishDBInfoReflection
	{
		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x0601B978 RID: 113016 RVA: 0x007CC217 File Offset: 0x007CA417
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingFishDBInfoReflection.descriptor;
			}
		}

		// Token: 0x0401555B RID: 87387
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0Zpc2hpbmdGaXNoREJJbmZvLnByb3RvEglwcm90by5uZXQi" + "ZwoRRmlzaGluZ0Zpc2hEQkluZm8SEwoLaW52ZW5faW5kZXgYASABKAMSCgoC" + "aWQYAiABKAUSDAoEc2l6ZRgDIAEoBRISCgp0aW1lX3ZhbHVlGAQgASgDEg8K" + "B2lzX2xvY2sYBSABKAhiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingFishDBInfo), FishingFishDBInfo.Parser, new string[] { "InvenIndex", "Id", "Size", "TimeValue", "IsLock" }, null, null, null, null)
		}));
	}
}
