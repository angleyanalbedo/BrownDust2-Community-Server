using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005204 RID: 20996
	public static class FieldEventSpawnInfoResponseReflection
	{
		// Token: 0x17004B4D RID: 19277
		// (get) Token: 0x06022D1D RID: 142621 RVA: 0x008D6998 File Offset: 0x008D4B98
		public static FileDescriptor Descriptor
		{
			get
			{
				return FieldEventSpawnInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x040182AD RID: 98989
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CipSZXNwb25zZS9GaWVsZEV2ZW50U3Bhd25JbmZvUmVzcG9uc2UucHJvdG8S", "CXByb3RvLm5ldBopQ29tbW9ucy9GaWVsZEV2ZW50U3Bhd25Qcm9ncmVzc0lu", "Zm8ucHJvdG8imAEKG0ZpZWxkRXZlbnRTcGF3bkluZm9SZXNwb25zZRJAChBj", "dXJyZW50X3Byb2dyZXNzGAEgASgLMiYucHJvdG8ubmV0LkZpZWxkRXZlbnRT", "cGF3blByb2dyZXNzSW5mbxIaChJkYWlseV9ub3JtYWxfY291bnQYAiABKAUS", "GwoTZGFpbHlfc3BlY2lhbF9jb3VudBgDIAEoBWIGcHJvdG8z" })), new FileDescriptor[] { FieldEventSpawnProgressInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FieldEventSpawnInfoResponse), FieldEventSpawnInfoResponse.Parser, new string[] { "CurrentProgress", "DailyNormalCount", "DailySpecialCount" }, null, null, null, null)
		}));
	}
}
