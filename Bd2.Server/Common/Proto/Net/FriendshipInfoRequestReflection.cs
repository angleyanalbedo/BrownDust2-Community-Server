using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004AEF RID: 19183
	public static class FriendshipInfoRequestReflection
	{
		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0601EDC4 RID: 126404 RVA: 0x00848E08 File Offset: 0x00847008
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipInfoRequestReflection.descriptor;
			}
		}

		// Token: 0x04016BF4 RID: 93172
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0ZyaWVuZHNoaXBJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8u" + "bmV0IiQKFUZyaWVuZHNoaXBJbmZvUmVxdWVzdBILCgNzZXEYASABKAViBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipInfoRequest), FriendshipInfoRequest.Parser, new string[] { "Seq" }, null, null, null, null)
		}));
	}
}
