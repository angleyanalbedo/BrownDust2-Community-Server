using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200460C RID: 17932
	public static class LifeHelperDBInfoReflection
	{
		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x0601C021 RID: 114721 RVA: 0x007DEB3F File Offset: 0x007DCD3F
		public static FileDescriptor Descriptor
		{
			get
			{
				return LifeHelperDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04015860 RID: 88160
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "Ch5Db21tb25zL0xpZmVIZWxwZXJEQkluZm8ucHJvdG8SCXByb3RvLm5ldBod", "Q29tbW9ucy9BdmF0YXJVc2VEQkluZm8ucHJvdG8i0gEKEExpZmVIZWxwZXJE", "QkluZm8SFAoMaGVscGVyX2luZGV4GAEgASgFEhEKCWhlbHBlcl9pZBgCIAEo", "BRIWCg5oZWxwZXJfc2xvdF9pZBgDIAEoBRITCgtoZWxwZXJfbmFtZRgEIAEo", "CRIvCgthdmF0YXJfaW5mbxgFIAEoCzIaLnByb3RvLm5ldC5BdmF0YXJVc2VE", "QkluZm8SEQoJd29ya190eXBlGAYgASgFEg8KB3dvcmtfaWQYByABKAUSEwoL", "YXNzaWduX2RhdGUYCCABKANiBnByb3RvMw==" })), new FileDescriptor[] { AvatarUseDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LifeHelperDBInfo), LifeHelperDBInfo.Parser, new string[] { "HelperIndex", "HelperId", "HelperSlotId", "HelperName", "AvatarInfo", "WorkType", "WorkId", "AssignDate" }, null, null, null, null)
		}));
	}
}
