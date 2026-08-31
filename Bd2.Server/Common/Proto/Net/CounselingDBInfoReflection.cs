using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004436 RID: 17462
	public static class CounselingDBInfoReflection
	{
		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x0601B39F RID: 111519 RVA: 0x007BA537 File Offset: 0x007B8737
		public static FileDescriptor Descriptor
		{
			get
			{
				return CounselingDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04014D2F RID: 85295
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL0NvdW5zZWxpbmdEQkluZm8ucHJvdG8SCXByb3RvLm5ldCJQ" + "ChBDb3Vuc2VsaW5nREJJbmZvEh0KFWZyaWVuZHNoaXBfY29zdHVtZV9pZBgB" + "IAEoBRIdChVjb3Vuc2VsaW5nX3Nlc3Npb25faWQYAiADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CounselingDBInfo), CounselingDBInfo.Parser, new string[] { "FriendshipCostumeId", "CounselingSessionId" }, null, null, null, null)
		}));
	}
}
