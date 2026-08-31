using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020055D1 RID: 21969
	public static class PrestigeSkinInfoResponseReflection
	{
		// Token: 0x170052C8 RID: 21192
		// (get) Token: 0x06024D16 RID: 150806 RVA: 0x0091A1AD File Offset: 0x009183AD
		public static FileDescriptor Descriptor
		{
			get
			{
				return PrestigeSkinInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04018D7B RID: 101755
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CidSZXNwb25zZS9QcmVzdGlnZVNraW5JbmZvUmVzcG9uc2UucHJvdG8SCXBy", "b3RvLm5ldBogQ29tbW9ucy9QcmVzdGlnZVNraW5EQkluZm8ucHJvdG8iVQoY", "UHJlc3RpZ2VTa2luSW5mb1Jlc3BvbnNlEjkKEnByZXN0aWdlX3NraW5faW5m", "bxgBIAMoCzIdLnByb3RvLm5ldC5QcmVzdGlnZVNraW5EQkluZm9iBnByb3Rv", "Mw==" })), new FileDescriptor[] { PrestigeSkinDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PrestigeSkinInfoResponse), PrestigeSkinInfoResponse.Parser, new string[] { "PrestigeSkinInfo" }, null, null, null, null)
		}));
	}
}
