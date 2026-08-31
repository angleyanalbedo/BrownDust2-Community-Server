using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020045ED RID: 17901
	public static class IdCardPresetInfoReflection
	{
		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x0601BEF1 RID: 114417 RVA: 0x007DBAB8 File Offset: 0x007D9CB8
		public static FileDescriptor Descriptor
		{
			get
			{
				return IdCardPresetInfoReflection.descriptor;
			}
		}

		// Token: 0x040157E5 RID: 88037
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL0lkQ2FyZFByZXNldEluZm8ucHJvdG8SCXByb3RvLm5ldBoY" + "Q29tbW9ucy9JZENhcmRJbmZvLnByb3RvIksKEElkQ2FyZFByZXNldEluZm8S" + "CgoCaWQYASABKAUSKwoMaWRfY2FyZF9pbmZvGAIgASgLMhUucHJvdG8ubmV0" + "LklkQ2FyZEluZm9iBnByb3RvMw=="), new FileDescriptor[] { IdCardInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(IdCardPresetInfo), IdCardPresetInfo.Parser, new string[] { "Id", "IdCardInfo" }, null, null, null, null)
		}));
	}
}
