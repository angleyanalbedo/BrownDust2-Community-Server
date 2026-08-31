using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaUserDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Db21tb25zL0dhY2hhVXNlckRCSW5mby5wcm90bxIJcHJvdG8ubmV0IvwB" + "Cg9HYWNoYVVzZXJEQkluZm8SEAoIZ3JvdXBfaWQYASABKAUSDQoFcG9pbnQY" + "AiABKAUSFwoPdG90YWxfYnV5X2NvdW50GAMgASgFEhsKE29uZV9mcmVlX3Bp" + "Y2tfY291bnQYBCABKAUSGwoTb25lX2Nhc2hfcGlja19jb3VudBgFIAEoBRIb" + "ChN0ZW5fZnJlZV9waWNrX2NvdW50GAYgASgFEhsKE3Rlbl9jYXNoX3BpY2tf" + "Y291bnQYByABKAUSGwoTZXhjaGFuZ2VfaXRlbV9jb3VudBgIIAEoBRIeChZl" + "eGNoYW5nZV9taWxlYWdlX2NvdW50GAkgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaUserDBInfo), GachaUserDBInfo.Parser, new string[9] { "GroupId", "Point", "TotalBuyCount", "OneFreePickCount", "OneCashPickCount", "TenFreePickCount", "TenCashPickCount", "ExchangeItemCount", "ExchangeMileageCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
