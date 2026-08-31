using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ItemAutoExchangeInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDb21tb25zL0l0ZW1BdXRvRXhjaGFuZ2VJbmZvLnByb3RvEglwcm90by5u" + "ZXQizQEKFEl0ZW1BdXRvRXhjaGFuZ2VJbmZvEhoKEm9yaWdpbmFsX2l0ZW1f" + "dHlwZRgBIAEoBRIYChBvcmlnaW5hbF9pdGVtX2lkGAIgASgFEhsKE29yaWdp" + "bmFsX2l0ZW1fY291bnQYAyABKAUSGgoSZXhjaGFuZ2VfaXRlbV90eXBlGAQg" + "ASgFEhgKEGV4Y2hhbmdlX2l0ZW1faWQYBSABKAUSGwoTZXhjaGFuZ2VfaXRl" + "bV9jb3VudBgGIAEoBRIPCgdzb3J0X2lkGAcgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ItemAutoExchangeInfo), ItemAutoExchangeInfo.Parser, new string[7] { "OriginalItemType", "OriginalItemId", "OriginalItemCount", "ExchangeItemType", "ExchangeItemId", "ExchangeItemCount", "SortId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
