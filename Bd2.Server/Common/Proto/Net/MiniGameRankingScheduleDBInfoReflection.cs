using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004665 RID: 18021
	public static class MiniGameRankingScheduleDBInfoReflection
	{
		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x0601C3D4 RID: 115668 RVA: 0x007E8714 File Offset: 0x007E6914
		public static FileDescriptor Descriptor
		{
			get
			{
				return MiniGameRankingScheduleDBInfoReflection.descriptor;
			}
		}

		// Token: 0x040159EA RID: 88554
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitDb21tb25zL01pbmlHYW1lUmFua2luZ1NjaGVkdWxlREJJbmZvLnByb3Rv" + "Eglwcm90by5uZXQibQodTWluaUdhbWVSYW5raW5nU2NoZWR1bGVEQkluZm8S" + "CgoCaWQYASABKAUSEgoKc3RhcnRfdGltZRgCIAEoAxIQCghlbmRfdGltZRgD" + "IAEoAxIaChJjYWxjdWxhdGVfZW5kX3RpbWUYBCABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MiniGameRankingScheduleDBInfo), MiniGameRankingScheduleDBInfo.Parser, new string[] { "Id", "StartTime", "EndTime", "CalculateEndTime" }, null, null, null, null)
		}));
	}
}
