using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common
{
	// Token: 0x02007C99 RID: 31897
	public static class FishingMapGroupTableReflection
	{
		// Token: 0x1701123B RID: 70203
		// (get) Token: 0x06046CD9 RID: 290009 RVA: 0x01137E05 File Offset: 0x01136005
		public static FileDescriptor Descriptor
		{
			get
			{
				return FishingMapGroupTableReflection.descriptor;
			}
		}

		// Token: 0x0402EB19 RID: 191257
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CjVjb21tb24uZGIvRmlzaGluZ19fX+uCmuyLnC9GaXNoaW5nTWFwR3JvdXBU", "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLLAQoURmlzaGluZ01h", "cEdyb3VwVGFibGUSEQoJY29zdENvdW50GAEgASgFEg4KBmNvc3RJZBgCIAEo", "BRIQCghjb3N0VHlwZRgDIAEoBRIXCg9kZXNjTG9jYWxUZXh0SWQYBCABKAUS", "CgoCaWQYBSABKAUSFQoNbWFwQmFja0dyb3VuZBgGIAEoCRIPCgdtYXBJY29u", "GAcgASgJEhIKCm5hbWVUZXh0SWQYCCABKAUSHQoVcmVjb21tZW5kRmlzaGlu", "Z0xldmVsGAkgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90", "by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FishingMapGroupTable), FishingMapGroupTable.Parser, new string[] { "CostCount", "CostId", "CostType", "DescLocalTextId", "Id", "MapBackGround", "MapIcon", "NameTextId", "RecommendFishingLevel" }, null, null, null, null)
		}));
	}
}
