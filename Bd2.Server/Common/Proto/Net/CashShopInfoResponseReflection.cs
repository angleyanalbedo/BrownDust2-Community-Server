using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CashShopInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9DYXNoU2hvcEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8u" + "bmV0Gh9Db21tb25zL0Nhc2hQcm9kdWN0REJJbmZvLnByb3RvIpsBChRDYXNo" + "U2hvcEluZm9SZXNwb25zZRIyCgxwcm9kdWN0X2luZm8YASADKAsyHC5wcm90" + "by5uZXQuQ2FzaFByb2R1Y3REQkluZm8SGAoQZGFpbHlfcmVzZXRfdGltZRgC" + "IAEoAxIZChF3ZWVrbHlfcmVzZXRfdGltZRgDIAEoAxIaChJtb250aGx5X3Jl" + "c2V0X3RpbWUYBCABKANiBnByb3RvMw=="), new FileDescriptor[1] { CashProductDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CashShopInfoResponse), CashShopInfoResponse.Parser, new string[4] { "ProductInfo", "DailyResetTime", "WeeklyResetTime", "MonthlyResetTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
