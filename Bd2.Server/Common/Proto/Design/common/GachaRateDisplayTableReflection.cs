using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GachaRateDisplayTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvR2FjaGFUYWJsZV9f672R6riwL0dhY2hhUmF0ZURpc3Bs" + "YXlUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKEAQoVR2FjaGFS" + "YXRlRGlzcGxheVRhYmxlEhMKC2Rpc3BsYXlSYXRlGAEgASgBEhQKDGdhY2hh" + "R3JvdXBJZBgCIAEoBRIPCgdncm91cElkGAMgASgFEgoKAmlkGAQgASgFEhUK" + "DW5hbWVMb2NhbFRleHQYBSABKAUSDAoEdHlwZRgGIAEoBUJEQhNQcm90by5E" + "ZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3Rv" + "LkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaRateDisplayTable), GachaRateDisplayTable.Parser, new string[6] { "DisplayRate", "GachaGroupId", "GroupId", "Id", "NameLocalText", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
