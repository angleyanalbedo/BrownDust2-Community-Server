using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CashProductTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvQ2FzaFNob3BUYWJsZV9f7Jyg66OM7IOB7KCQL0Nhc2hQ" + "cm9kdWN0VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i0gIKEENh" + "c2hQcm9kdWN0VGFibGUSFAoMYXBwbGVJbkFwcElkGAEgASgJEhgKEGJvbnVz" + "UmFuZG9tYm94SWQYAiABKAUSFQoNZ29vZ2xlSW5BcHBJZBgDIAEoCRIPCgdn" + "cm91cElkGAQgASgFEgoKAmlkGAUgASgFEhIKCnByaWNlQ291bnQYBiABKAUS" + "DwoHcHJpY2VJZBgHIAEoBRIRCglwcmljZVR5cGUYCCABKAUSEAoIcHJpb3Jp" + "dHkYCSABKAUSGgoScHJvZHVjdExvY2FsVGV4dElkGAogASgFEhoKEnB1cmNo" + "YXNlTGltaXRDb3VudBgLIAEoBRIZChFwdXJjaGFzZUxpbWl0VHlwZRgMIAEo" + "BRITCgtyYW5kb21ib3hJZBgNIAEoBRIRCglzYWxlR3JvdXAYDiABKAUSFQoN" + "dGltZUxpbWl0VHlwZRgPIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFa" + "FS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CashProductTable), CashProductTable.Parser, new string[15]
		{
			"AppleInAppId", "BonusRandomboxId", "GoogleInAppId", "GroupId", "Id", "PriceCount", "PriceId", "PriceType", "Priority", "ProductLocalTextId",
			"PurchaseLimitCount", "PurchaseLimitType", "RandomboxId", "SaleGroup", "TimeLimitType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
