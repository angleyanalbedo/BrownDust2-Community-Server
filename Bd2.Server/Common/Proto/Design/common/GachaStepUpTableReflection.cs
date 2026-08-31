using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GachaStepUpTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNjb21tb24uZGIvR2FjaGFUYWJsZV9f672R6riwL0dhY2hhU3RlcFVwVGFi" + "bGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24itgEKEEdhY2hhU3RlcFVw" + "VGFibGUSDwoHZml4ZWRJZBgBIAEoBRIYChBmaXhlZExvY2FsVGV4dElkGAIg" + "ASgFEhQKDGdhY2hhR3JvdXBJZBgDIAEoBRIPCgdnYWNoYUlkGAQgASgFEg8K" + "B2dyb3VwSWQYBSABKAUSCgoCaWQYBiABKAUSGgoSaXNEaXNwbGF5Rml4ZWRJ" + "dGVtGAcgASgFEhcKD3N0ZXBMb2NhbFRleHRJZBgIIAEoBUJEQhNQcm90by5E" + "ZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3Rv" + "LkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaStepUpTable), GachaStepUpTable.Parser, new string[8] { "FixedId", "FixedLocalTextId", "GachaGroupId", "GachaId", "GroupId", "Id", "IsDisplayFixedItem", "StepLocalTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
