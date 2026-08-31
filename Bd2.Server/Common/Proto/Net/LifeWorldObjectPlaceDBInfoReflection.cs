using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004621 RID: 17953
	public static class LifeWorldObjectPlaceDBInfoReflection
	{
		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x0601C0F4 RID: 114932 RVA: 0x007E0EC2 File Offset: 0x007DF0C2
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeWorldObjectPlaceDBInfoReflection.descriptor;
			}
		}

		// Token: 0x040158BB RID: 88251
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CihDb21tb25zL0xpZmVXb3JsZE9iamVjdFBsYWNlREJJbmZvLnByb3RvEglw", "cm90by5uZXQaI0NvbW1vbnMvTGlmZVdvcmxkT2JqZWN0REJJbmZvLnByb3Rv", "ImAKGkxpZmVXb3JsZE9iamVjdFBsYWNlREJJbmZvEhAKCGNodW5rX2lkGAEg", "ASgFEjAKBm9iamVjdBgCIAMoCzIgLnByb3RvLm5ldC5MaWZlV29ybGRPYmpl", "Y3REQkluZm9iBnByb3RvMw==" })), new FileDescriptor[] { LifeWorldObjectDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeWorldObjectPlaceDBInfo), LifeWorldObjectPlaceDBInfo.Parser, new string[] { "ChunkId", "Object" }, null, null, null, null)
		}));
	}
}
