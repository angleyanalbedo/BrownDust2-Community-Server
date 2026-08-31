using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ItemAutoUpgradeInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL0l0ZW1BdXRvVXBncmFkZUluZm8ucHJvdG8SCXByb3RvLm5l" + "dCKKAQoTSXRlbUF1dG9VcGdyYWRlSW5mbxITCgtpbnZlbl9pbmRleBgBIAEo" + "AxIRCglpdGVtX3R5cGUYAiABKAUSDwoHaXRlbV9pZBgDIAEoBRIUCgxiZWZv" + "cmVfbGV2ZWwYBCABKAUSEwoLYWZ0ZXJfbGV2ZWwYBSABKAUSDwoHc29ydF9p" + "ZBgGIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ItemAutoUpgradeInfo), ItemAutoUpgradeInfo.Parser, new string[6] { "InvenIndex", "ItemType", "ItemId", "BeforeLevel", "AfterLevel", "SortId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
