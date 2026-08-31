using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EquipmentOptionRerollTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkJjb21tb24uZGIvRXF1aXBtZW50VGFibGVfX1/snqXruYQvRXF1aXBtZW50" + "T3B0aW9uUmVyb2xsVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i" + "hgEKGkVxdWlwbWVudE9wdGlvblJlcm9sbFRhYmxlEgoKAmlkGAEgASgFEhUK" + "DWxvY2tJdGVtQ291bnQYAiADKAUSFwoPcmVyb2xsSXRlbUNvdW50GAMgAygF" + "EhQKDHJlcm9sbEl0ZW1JZBgEIAMoBRIWCg5yZXJvbGxJdGVtVHlwZRgFIAMo" + "BUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNv" + "bW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipmentOptionRerollTable), EquipmentOptionRerollTable.Parser, new string[5] { "Id", "LockItemCount", "RerollItemCount", "RerollItemId", "RerollItemType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
