using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class NewAccountSupplyItemTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ckljb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9O" + "ZXdBY2NvdW50U3VwcGx5SXRlbVRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24u" + "Y29tbW9uIm4KGU5ld0FjY291bnRTdXBwbHlJdGVtVGFibGUSCgoCaWQYASAB" + "KAUSFwoPc3VwcGx5SXRlbUNvdW50GAIgAygFEhQKDHN1cHBseUl0ZW1JZBgD" + "IAMoBRIWCg5zdXBwbHlJdGVtVHlwZRgEIAMoBUJEQhNQcm90by5EZXNpZ24u" + "Y29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2ln" + "bi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(NewAccountSupplyItemTable), NewAccountSupplyItemTable.Parser, new string[4] { "Id", "SupplyItemCount", "SupplyItemId", "SupplyItemType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
