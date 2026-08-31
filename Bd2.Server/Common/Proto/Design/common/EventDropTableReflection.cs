using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EventDropTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0V2ZW50RHJvcFRh" + "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIqABCg5FdmVudERyb3BU" + "YWJsZRIcChRldmVudE5hbWVMb2NhbFRleHRJZBgBIAEoBRIKCgJpZBgCIAEo" + "BRIOCgZwYWNrSWQYAyADKAUSDQoFcmF0aW8YBCABKAUSFwoPcmV3YXJkSXRl" + "bUNvdW50GAUgASgFEhQKDHJld2FyZEl0ZW1JZBgGIAEoBRIWCg5yZXdhcmRJ" + "dGVtVHlwZRgHIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJv" + "dG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventDropTable), EventDropTable.Parser, new string[7] { "EventNameLocalTextId", "Id", "PackId", "Ratio", "RewardItemCount", "RewardItemId", "RewardItemType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
