using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaLogDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDb21tb25zL0dhY2hhTG9nREJJbmZvLnByb3RvEglwcm90by5uZXQaFENv" + "bW1vbnMvRGVmaW5lLnByb3RvGiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRs" + "ZS5wcm90bxoeQ29tbW9ucy9HYWNoYUZpeGVkREJJbmZvLnByb3RvGh5Db21t" + "b25zL0l0ZW1NYXRlcmlhbEluZm8ucHJvdG8ixAMKDkdhY2hhTG9nREJJbmZv" + "EhYKDmdhY2hhX2dyb3VwX2lkGAEgASgFEhAKCGdhY2hhX2lkGAIgASgFEjAK" + "CGJ1eV90eXBlGAMgASgOMh4ucHJvdG8ubmV0LkRlZmluZV9HYWNoYUJ1eVR5" + "cGUSEwoLZ2FjaGFfY291bnQYBCABKAUSEQoJZ2V0X3BvaW50GAUgASgFEi8K" + "CmdhY2hhX3R5cGUYBiABKA4yGy5wcm90by5uZXQuRGVmaW5lX0dhY2hhVHlw" + "ZRIWCg5waWNrdXBfaXRlbV9pZBgHIAEoBRI1ChBnYWNoYV9maXhlZF9pbmZv" + "GAggAygLMhsucHJvdG8ubmV0LkdhY2hhRml4ZWREQkluZm8SOQoScmV3YXJk" + "X2luZm9fYnVuZGxlGAkgASgLMh0ucHJvdG8ubmV0LlJld2FyZERCSW5mb0J1" + "bmRsZRIQCghuZXdfc29ydBgKIAMoBRIWCg5zZWxlY3Rpb25fc29ydBgLIAMo" + "BRI3ChJkZWNyZWFzZV9pdGVtX2luZm8YDCADKAsyGy5wcm90by5uZXQuSXRl" + "bU1hdGVyaWFsSW5mbxIQCghsb2dfdGltZRgNIAEoAyL/AgoTR2FjaGFUb3Rh" + "bENvdW50SW5mbxI2Cg5nYWNoYV9sb2dfdHlwZRgBIAEoDjIeLnByb3RvLm5l" + "dC5EZWZpbmVfR2FjaGFMb2dUeXBlEh0KFWNoYXI1X3BpY2tfdXBfY29zdHVt" + "ZRgCIAEoBRIVCg1jaGFyNV9jb3N0dW1lGAMgASgFEhUKDWNoYXI0X2Nvc3R1" + "bWUYBCABKAUSFQoNY2hhcjNfY29zdHVtZRgFIAEoBRIcChRjaGFyNV9waWNr" + "X3VwX2VxdWlwNBgGIAEoBRIUCgxjaGFyNV9lcXVpcDQYByABKAUSFAoMY2hh" + "cjVfZXF1aXAzGAggASgFEhQKDGNoYXI0X2VxdWlwNBgJIAEoBRIUCgxjaGFy" + "NF9lcXVpcDMYCiABKAUSFAoMY2hhcjRfZXF1aXAyGAsgASgFEhQKDGNoYXIz" + "X2VxdWlwNBgMIAEoBRIUCgxjaGFyM19lcXVpcDMYDSABKAUSFAoMY2hhcjNf" + "ZXF1aXAyGA4gASgFYgZwcm90bzM="), new FileDescriptor[4]
	{
		DefineReflection.Descriptor,
		RewardDBInfoBundleReflection.Descriptor,
		GachaFixedDBInfoReflection.Descriptor,
		ItemMaterialInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(GachaLogDBInfo), GachaLogDBInfo.Parser, new string[13]
		{
			"GachaGroupId", "GachaId", "BuyType", "GachaCount", "GetPoint", "GachaType", "PickupItemId", "GachaFixedInfo", "RewardInfoBundle", "NewSort",
			"SelectionSort", "DecreaseItemInfo", "LogTime"
		}, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(GachaTotalCountInfo), GachaTotalCountInfo.Parser, new string[14]
		{
			"GachaLogType", "Char5PickUpCostume", "Char5Costume", "Char4Costume", "Char3Costume", "Char5PickUpEquip4", "Char5Equip4", "Char5Equip3", "Char4Equip4", "Char4Equip3",
			"Char4Equip2", "Char3Equip4", "Char3Equip3", "Char3Equip2"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
