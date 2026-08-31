using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004609 RID: 17929
	public static class LifeEatFoodDBInfoReflection
	{
		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x0601C007 RID: 114695 RVA: 0x007DE822 File Offset: 0x007DCA22
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeEatFoodDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015858 RID: 88152
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0xpZmVFYXRGb29kREJJbmZvLnByb3RvEglwcm90by5uZXQi" + "NgoRTGlmZUVhdEZvb2REQkluZm8SDwoHaXRlbV9pZBgBIAEoBRIQCghlbmRf" + "dGltZRgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeEatFoodDBInfo), LifeEatFoodDBInfo.Parser, new string[] { "ItemId", "EndTime" }, null, null, null, null)
		}));
	}
}
