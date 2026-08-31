using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200563D RID: 22077
	public static class RootSortIdInfoResponseReflection
	{
		// Token: 0x170053CB RID: 21451
		// (get) Token: 0x060250E9 RID: 151785 RVA: 0x00923E6C File Offset: 0x0092206C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RootSortIdInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04018F1C RID: 102172
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiVSZXNwb25zZS9Sb290U29ydElkSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90", "by5uZXQiOwoOUm9vdFNvcnRJZEluZm8SDAoEdHlwZRgBIAEoBRIKCgJpZBgC", "IAEoBRIPCgdzb3J0X2lkGAMgASgFIksKFlJvb3RTb3J0SWRJbmZvUmVzcG9u", "c2USMQoOcm9vdF9zb3J0X2luZm8YASADKAsyGS5wcm90by5uZXQuUm9vdFNv", "cnRJZEluZm9iBnByb3RvMw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RootSortIdInfo), RootSortIdInfo.Parser, new string[] { "Type", "Id", "SortId" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(RootSortIdInfoResponse), RootSortIdInfoResponse.Parser, new string[] { "RootSortInfo" }, null, null, null, null)
		}));
	}
}
