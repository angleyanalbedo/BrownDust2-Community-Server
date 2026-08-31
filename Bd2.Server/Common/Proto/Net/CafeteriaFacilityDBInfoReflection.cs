using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020043ED RID: 17389
	public static class CafeteriaFacilityDBInfoReflection
	{
		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x0601B0D3 RID: 110803 RVA: 0x007B2A05 File Offset: 0x007B0C05
		public static FileDescriptor Descriptor
		{
			get
			{
				return CafeteriaFacilityDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04014BE6 RID: 84966
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDb21tb25zL0NhZmV0ZXJpYUZhY2lsaXR5REJJbmZvLnByb3RvEglwcm90" + "by5uZXQiLgoXQ2FmZXRlcmlhRmFjaWxpdHlEQkluZm8SEwoLZmFjaWxpdHlf" + "aWQYASABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CafeteriaFacilityDBInfo), CafeteriaFacilityDBInfo.Parser, new string[] { "FacilityId" }, null, null, null, null)
		}));
	}
}
