using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CashProductDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0Nhc2hQcm9kdWN0REJJbmZvLnByb3RvEglwcm90by5uZXQi" + "hgEKEUNhc2hQcm9kdWN0REJJbmZvEhAKCGdyb3VwX2lkGAEgASgFEgoKAmlk" + "GAIgASgFEhIKCnNhbGVfZ3JvdXAYAyABKAUSEgoKc3RhcnRfdGltZRgEIAEo" + "AxIQCghlbmRfdGltZRgFIAEoAxIZChFlbmRfZGVsYXlfbWludXRlcxgGIAEo" + "BWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CashProductDBInfo), CashProductDBInfo.Parser, new string[6] { "GroupId", "Id", "SaleGroup", "StartTime", "EndTime", "EndDelayMinutes" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
