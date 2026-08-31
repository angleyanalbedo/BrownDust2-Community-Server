using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005394 RID: 21396
	public static class IdCardPresetInfoResponseReflection
	{
		// Token: 0x17004E59 RID: 20057
		// (get) Token: 0x06023A2E RID: 145966 RVA: 0x008F1B18 File Offset: 0x008EFD18
		public static FileDescriptor Descriptor
		{
			get
			{
				return IdCardPresetInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x0401870A RID: 100106
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9JZENhcmRQcmVzZXRJbmZvUmVzcG9uc2UucHJvdG8SCXBy" + "b3RvLm5ldBoeQ29tbW9ucy9JZENhcmRQcmVzZXRJbmZvLnByb3RvIkwKGElk" + "Q2FyZFByZXNldEluZm9SZXNwb25zZRIwCgtwcmVzZXRfaW5mbxgBIAMoCzIb" + "LnByb3RvLm5ldC5JZENhcmRQcmVzZXRJbmZvYgZwcm90bzM="), new FileDescriptor[] { IdCardPresetInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(IdCardPresetInfoResponse), IdCardPresetInfoResponse.Parser, new string[] { "PresetInfo" }, null, null, null, null)
		}));
	}
}
