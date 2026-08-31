using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CashShopBuyRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0Nhc2hTaG9wQnV5UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "GhVDb21tb25zL0VudkluZm8ucHJvdG8aF0NvbW1vbnMvUHJpY2VJbmZvLnBy" + "b3RvGhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8isQIKEkNhc2hTaG9wQnV5" + "UmVxdWVzdBILCgNzZXEYASABKAUSEAoIZ3JvdXBfaWQYAiABKAUSEgoKcHJv" + "ZHVjdF9pZBgDIAEoBRISCgpzYWxlX2dyb3VwGAQgASgFEg4KBnBheV9pZBgF" + "IAEoCRIYChBwdXJjaGFzZV9yZWNlaXB0GAYgASgJEiQKCGVudl9pbmZvGAcg" + "ASgLMhIucHJvdG8ubmV0LkVudkluZm8SKAoKcHJpY2VfaW5mbxgIIAEoCzIU" + "LnByb3RvLm5ldC5QcmljZUluZm8SLAoNdXNlX2l0ZW1faW5mbxgJIAMoCzIV" + "LnByb3RvLm5ldC5JdGVtREJJbmZvEhEKCWJ1eV9jb3VudBgKIAEoBRIZChFl" + "dmVudF9zY2hlZHVsZV9pZBgLIAEoBWIGcHJvdG8z"), new FileDescriptor[3]
	{
		EnvInfoReflection.Descriptor,
		PriceInfoReflection.Descriptor,
		ItemDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CashShopBuyRequest), CashShopBuyRequest.Parser, new string[11]
		{
			"Seq", "GroupId", "ProductId", "SaleGroup", "PayId", "PurchaseReceipt", "EnvInfo", "PriceInfo", "UseItemInfo", "BuyCount",
			"EventScheduleId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
