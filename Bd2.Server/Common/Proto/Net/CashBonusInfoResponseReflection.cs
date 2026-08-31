using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net
{
	// Token: 0x02005006 RID: 20486
	public static class CashBonusInfoResponseReflection
	{
		// Token: 0x17004716 RID: 18198
		// (get) Token: 0x06021BD8 RID: 138200 RVA: 0x008AF368 File Offset: 0x008AD568
		public static FileDescriptor Descriptor
		{
			get
			{
				return CashBonusInfoResponseReflection.descriptor;
			}
		}

		// Token: 0x04017C64 RID: 97380
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9DYXNoQm9udXNJbmZvUmVzcG9uc2UucHJvdG8SCXByb3Rv" + "Lm5ldBodQ29tbW9ucy9DYXNoQm9udXNEQkluZm8ucHJvdG8iRwoVQ2FzaEJv" + "bnVzSW5mb1Jlc3BvbnNlEi4KCmJvbnVzX2luZm8YASADKAsyGi5wcm90by5u" + "ZXQuQ2FzaEJvbnVzREJJbmZvYgZwcm90bzM="), new FileDescriptor[] { CashBonusDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CashBonusInfoResponse), CashBonusInfoResponse.Parser, new string[] { "BonusInfo" }, null, null, null, null)
		}));
	}
}
