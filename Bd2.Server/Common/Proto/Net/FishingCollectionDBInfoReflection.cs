using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004567 RID: 17767
	public static class FishingCollectionDBInfoReflection
	{
		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0601B935 RID: 112949 RVA: 0x007CB73F File Offset: 0x007C993F
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingCollectionDBInfoReflection.descriptor;
			}
		}

		// Token: 0x0401553F RID: 87359
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDb21tb25zL0Zpc2hpbmdDb2xsZWN0aW9uREJJbmZvLnByb3RvEglwcm90" + "by5uZXQiYwoXRmlzaGluZ0NvbGxlY3Rpb25EQkluZm8SDwoHZmlzaF9pZBgB" + "IAEoBRIQCghtYXhfc2l6ZRgCIAEoBRIQCghtaW5fc2l6ZRgDIAEoBRITCgtj" + "cmVhdGVfdGltZRgEIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingCollectionDBInfo), FishingCollectionDBInfo.Parser, new string[] { "FishId", "MaxSize", "MinSize", "CreateTime" }, null, null, null, null)
		}));
	}
}
