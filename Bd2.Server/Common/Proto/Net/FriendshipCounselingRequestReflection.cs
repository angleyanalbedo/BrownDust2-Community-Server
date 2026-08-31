using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02004AE9 RID: 19177
	public static class FriendshipCounselingRequestReflection
	{
		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x0601ED89 RID: 126345 RVA: 0x0084849B File Offset: 0x0084669B
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendshipCounselingRequestReflection.descriptor;
			}
		}

		// Token: 0x04016BDB RID: 93147
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CilSZXF1ZXN0L0ZyaWVuZHNoaXBDb3Vuc2VsaW5nUmVxdWVzdC5wcm90bxIJ", "cHJvdG8ubmV0InoKG0ZyaWVuZHNoaXBDb3Vuc2VsaW5nUmVxdWVzdBILCgNz", "ZXEYASABKAUSEgoKY29zdHVtZV9pZBgCIAEoBRISCgpzZXNzaW9uX2lkGAMg", "ASgFEhQKDHNlbGVjdF9pbmRleBgEIAEoBRIQCghpc19xdWljaxgFIAEoCGIG", "cHJvdG8z" })), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendshipCounselingRequest), FriendshipCounselingRequest.Parser, new string[] { "Seq", "CostumeId", "SessionId", "SelectIndex", "IsQuick" }, null, null, null, null)
		}));
	}
}
