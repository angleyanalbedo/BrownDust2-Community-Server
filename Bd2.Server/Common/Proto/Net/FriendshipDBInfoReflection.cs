using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200458B RID: 17803
	public static class FriendshipDBInfoReflection
	{
		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x0601BAA1 RID: 113313 RVA: 0x007CEFB0 File Offset: 0x007CD1B0
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipDBInfoReflection.descriptor;
			}
		}

		// Token: 0x040155D2 RID: 87506
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL0ZyaWVuZHNoaXBEQkluZm8ucHJvdG8SCXByb3RvLm5ldCJr" + "ChBGcmllbmRzaGlwREJJbmZvEh0KFWZyaWVuZHNoaXBfY29zdHVtZV9pZBgB" + "IAEoBRINCgVsZXZlbBgCIAEoBRILCgNleHAYAyABKAUSHAoUbGFzdF9jb3Vu" + "c2VsaW5nX2RhdGUYBCABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipDBInfo), FriendshipDBInfo.Parser, new string[] { "FriendshipCostumeId", "Level", "Exp", "LastCounselingDate" }, null, null, null, null)
		}));
	}
}
