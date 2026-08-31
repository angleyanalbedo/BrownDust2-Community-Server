using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004AF2 RID: 19186
	public static class FriendshipSpecialEpisodeClearRequestReflection
	{
		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x0601EDDC RID: 126428 RVA: 0x00849064 File Offset: 0x00847264
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipSpecialEpisodeClearRequestReflection.descriptor;
			}
		}

		// Token: 0x04016BFA RID: 93178
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjJSZXF1ZXN0L0ZyaWVuZHNoaXBTcGVjaWFsRXBpc29kZUNsZWFyUmVxdWVz" + "dC5wcm90bxIJcHJvdG8ubmV0IlEKJEZyaWVuZHNoaXBTcGVjaWFsRXBpc29k" + "ZUNsZWFyUmVxdWVzdBILCgNzZXEYASABKAUSEAoIZ3JvdXBfaWQYAiABKAUS" + "CgoCaWQYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipSpecialEpisodeClearRequest), FriendshipSpecialEpisodeClearRequest.Parser, new string[] { "Seq", "GroupId", "Id" }, null, null, null, null)
		}));
	}
}
