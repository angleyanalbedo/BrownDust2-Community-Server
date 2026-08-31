using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PriceInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdDb21tb25zL1ByaWNlSW5mby5wcm90bxIJcHJvdG8ubmV0IjcKCVByaWNlSW5mbxIbChNwcmljZV9jdXJyZW5jeV9jb2RlGAEgASgJEg0KBXByaWNlGAIgASgCYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PriceInfo), PriceInfo.Parser, new string[2] { "PriceCurrencyCode", "Price" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
