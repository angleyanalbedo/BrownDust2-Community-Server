using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ClearPackageTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvQ2FzaFNob3BUYWJsZV9f7Jyg66OM7IOB7KCQL0NsZWFy" + "UGFja2FnZVRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIncKEUNs" + "ZWFyUGFja2FnZVRhYmxlEhgKEGNvbnRlbnRzVGlja2V0SWQYASABKAUSDwoH" + "Z3JvdXBJZBgCIAEoBRIOCgZwYWNrSWQYAyABKAUSGQoRcmV3YXJkUmFuZG9t" + "Qm94SWQYBCABKAUSDAoEdHlwZRgFIAEoBUJEQhNQcm90by5EZXNpZ24uY29t" + "bW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5j" + "b21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ClearPackageTable), ClearPackageTable.Parser, new string[5] { "ContentsTicketId", "GroupId", "PackId", "RewardRandomBoxId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
