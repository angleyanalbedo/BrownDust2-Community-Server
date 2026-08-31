using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200443F RID: 17471
	public static class DatingMessageRewardInfoReflection
	{
		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x0601B3F8 RID: 111608 RVA: 0x007BB26A File Offset: 0x007B946A
		public static FileDescriptor Descriptor
		{
			get
			{
				return DatingMessageRewardInfoReflection.descriptor;
			}
		}

		// Token: 0x04014D53 RID: 85331
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDb21tb25zL0RhdGluZ01lc3NhZ2VSZXdhcmRJbmZvLnByb3RvEglwcm90" + "by5uZXQiNwoXRGF0aW5nTWVzc2FnZVJld2FyZEluZm8SEAoIZ3JvdXBfaWQY" + "ASABKAUSCgoCaWQYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DatingMessageRewardInfo), DatingMessageRewardInfo.Parser, new string[] { "GroupId", "Id" }, null, null, null, null)
		}));
	}
}
