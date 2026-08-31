using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GachaTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1jb21tb24uZGIvR2FjaGFUYWJsZV9f672R6riwL0dhY2hhVGFibGUucHJv" + "dG8SE1Byb3RvLkRlc2lnbi5jb21tb24i/wEKCkdhY2hhVGFibGUSGgoSZGFp" + "bHlQYXlHYWNoYUNvdW50GAEgASgFEh8KF2RhaWx5UGF5R2FjaGFQcmljZUNv" + "dW50GAIgASgFEhQKDGZyZWVDb3VudERheRgDIAEoBRISCgpnYWNoYUNvdW50" + "GAQgASgFEhgKEGdhY2hhTG9jYWxUZXh0SWQYBSABKAUSFQoNZ2FjaGFSZXdh" + "cmRJZBgGIAEoBRIVCg1nYWNoYVRpY2tldElkGAcgASgFEgoKAmlkGAggASgF" + "EhIKCnByaWNlQ291bnQYCSABKAUSDwoHcHJpY2VJZBgKIAEoBRIRCglwcmlj" + "ZVR5cGUYCyABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3Rv" + "LkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaTable), GachaTable.Parser, new string[11]
		{
			"DailyPayGachaCount", "DailyPayGachaPriceCount", "FreeCountDay", "GachaCount", "GachaLocalTextId", "GachaRewardId", "GachaTicketId", "Id", "PriceCount", "PriceId",
			"PriceType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
