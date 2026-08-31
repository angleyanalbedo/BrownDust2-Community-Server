using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ShopDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb21tb25zL1Nob3BEQkluZm8ucHJvdG8SCXByb3RvLm5ldBobQ29tbW9u" + "cy9Qcm9kdWN0REJJbmZvLnByb3RvIm0KClNob3BEQkluZm8SGAoQc2hvcF9y" + "ZW1haW5fdGltZRgBIAEoBRIWCg5zaG9wX3JhbmRfc2VlZBgCIAEoBRItCgtw" + "cm9kdWN0SW5mbxgDIAMoCzIYLnByb3RvLm5ldC5Qcm9kdWN0REJJbmZvYgZw" + "cm90bzM="), new FileDescriptor[1] { ProductDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShopDBInfo), ShopDBInfo.Parser, new string[3] { "ShopRemainTime", "ShopRandSeed", "ProductInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
