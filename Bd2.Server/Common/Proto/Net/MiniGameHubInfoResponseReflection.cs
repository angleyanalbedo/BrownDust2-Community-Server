using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x020054A4 RID: 21668
	public static class MiniGameHubInfoResponseReflection
	{
		// Token: 0x17005069 RID: 20585
		// (get) Token: 0x0602431E RID: 148254 RVA: 0x00904463 File Offset: 0x00902663
		public static FileDescriptor Descriptor
		{
			get
			{
				return MiniGameHubInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x040189F6 RID: 100854
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[] { "CiZSZXNwb25zZS9NaW5pR2FtZUh1YkluZm9SZXNwb25zZS5wcm90bxIJcHJv", "dG8ubmV0Gh9Db21tb25zL01pbmlHYW1lSHViREJJbmZvLnByb3RvGitDb21t", "b25zL01pbmlHYW1lUmFua2luZ1NjaGVkdWxlREJJbmZvLnByb3RvIp8BChdN", "aW5pR2FtZUh1YkluZm9SZXNwb25zZRI4ChJtaW5pX2dhbWVfaHViX2luZm8Y", "ASADKAsyHC5wcm90by5uZXQuTWluaUdhbWVIdWJEQkluZm8SSgoYbmV4dF9z", "ZXR0bGVtZW50X3NjaGVkdWxlGAIgASgLMigucHJvdG8ubmV0Lk1pbmlHYW1l", "UmFua2luZ1NjaGVkdWxlREJJbmZvYgZwcm90bzM=" })), new FileDescriptor[]
		{
			MiniGameHubDBInfoReflection.Descriptor,
			MiniGameRankingScheduleDBInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MiniGameHubInfoResponse), MiniGameHubInfoResponse.Parser, new string[] { "MiniGameHubInfo", "NextSettlementSchedule" }, null, null, null, null)
		}));
	}
}
