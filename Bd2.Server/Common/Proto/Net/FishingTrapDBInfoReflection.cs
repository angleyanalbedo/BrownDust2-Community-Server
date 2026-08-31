using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004585 RID: 17797
	public static class FishingTrapDBInfoReflection
	{
		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x0601BA60 RID: 113248 RVA: 0x007CE3D0 File Offset: 0x007CC5D0
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingTrapDBInfoReflection.descriptor;
			}
		}

		// Token: 0x040155B3 RID: 87475
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0Zpc2hpbmdUcmFwREJJbmZvLnByb3RvEglwcm90by5uZXQi" + "MgoRRmlzaGluZ1RyYXBEQkluZm8SDwoHZmlzaF9pZBgBIAEoBRIMCgRzaXpl" + "GAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingTrapDBInfo), FishingTrapDBInfo.Parser, new string[] { "FishId", "Size" }, null, null, null, null)
		}));
	}
}
