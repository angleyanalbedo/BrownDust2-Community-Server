using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004AEC RID: 19180
	public static class FriendshipGiftRequestReflection
	{
		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x0601EDA9 RID: 126377 RVA: 0x008489EA File Offset: 0x00846BEA
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipGiftRequestReflection.descriptor;
			}
		}

		// Token: 0x04016BE9 RID: 93161
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiNSZXF1ZXN0L0ZyaWVuZHNoaXBHaWZ0UmVxdWVzdC5wcm90bxIJcHJvdG8u", "bmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8iYgoVRnJpZW5kc2hpcEdp", "ZnRSZXF1ZXN0EgsKA3NlcRgBIAEoBRISCgpjb3N0dW1lX2lkGAIgASgFEigK", "CWl0ZW1faW5mbxgDIAMoCzIVLnByb3RvLm5ldC5JdGVtREJJbmZvYgZwcm90", "bzM=" })), new FileDescriptor[] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipGiftRequest), FriendshipGiftRequest.Parser, new string[] { "Seq", "CostumeId", "ItemInfo" }, null, null, null, null)
		}));
	}
}
