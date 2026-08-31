using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020050E5 RID: 20709
	public static class DailyStoryInfoResponseReflection
	{
		// Token: 0x170048D4 RID: 18644
		// (get) Token: 0x06022338 RID: 140088 RVA: 0x008BEC13 File Offset: 0x008BCE13
		public static FileDescriptor Descriptor
		{
			get
			{
				return DailyStoryInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04017EEC RID: 98028
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9EYWlseVN0b3J5SW5mb1Jlc3BvbnNlLnByb3RvEglwcm90" + "by5uZXQiJgoWRGFpbHlTdG9yeUluZm9SZXNwb25zZRIMCgRpbmZvGAEgAygF" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DailyStoryInfoResponse), DailyStoryInfoResponse.Parser, new string[] { "Info" }, null, null, null, null)
		}));
	}
}
