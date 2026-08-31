using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MiniGameBingoTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvTWluaUdhbWVfX1/rr7jri4gg6rKM7J6EL01pbmlHYW1l" + "QmluZ29UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLhAQoSTWlu" + "aUdhbWVCaW5nb1RhYmxlEiIKGmJpbmdvQ29tcGxldGVSZXdhcmRHcm91cElk" + "GAEgASgFEh4KFmJpbmdvTGluZVJld2FyZEdyb3VwSWQYAiABKAUSGgoSYmlu" + "Z29SZXdhcmRHcm91cElkGAMgASgFEhUKDWJpbmdvVWlQcmVmYWIYBCABKAkS" + "EwoLY29sdW1uQ291bnQYBSABKAUSCgoCaWQYBiABKAUSEQoJaXRlbUNvdW50" + "GAcgASgFEg4KBml0ZW1JZBgIIAEoBRIQCghpdGVtVHlwZRgJIAEoBUJEQhNQ" + "cm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoC" + "E1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBingoTable), MiniGameBingoTable.Parser, new string[9] { "BingoCompleteRewardGroupId", "BingoLineRewardGroupId", "BingoRewardGroupId", "BingoUiPrefab", "ColumnCount", "Id", "ItemCount", "ItemId", "ItemType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
