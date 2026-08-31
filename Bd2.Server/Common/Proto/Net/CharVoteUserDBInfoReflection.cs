using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x0200440F RID: 17423
	public static class CharVoteUserDBInfoReflection
	{
		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x0601B218 RID: 111128 RVA: 0x007B5B48 File Offset: 0x007B3D48
		public static FileDescriptor Descriptor
		{
			get
			{
				return CharVoteUserDBInfoReflection.descriptor;
			}
		}

		// Token: 0x04014C66 RID: 85094
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiBDb21tb25zL0NoYXJWb3RlVXNlckRCSW5mby5wcm90bxIJcHJvdG8ubmV0", "In4KEkNoYXJWb3RlVXNlckRCSW5mbxINCgVyb3VuZBgBIAEoBRIUCgxjYW5k", "aWRhdGVfaWQYAiABKAUSEwoLdG90YWxfY291bnQYAyABKAUSFAoMbm9ybWFs", "X2NvdW50GAQgASgFEhgKEGFkZGl0aW9uYWxfY291bnQYBSABKAViBnByb3Rv", "Mw==" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CharVoteUserDBInfo), CharVoteUserDBInfo.Parser, new string[] { "Round", "CandidateId", "TotalCount", "NormalCount", "AdditionalCount" }, null, null, null, null)
		}));
	}
}
