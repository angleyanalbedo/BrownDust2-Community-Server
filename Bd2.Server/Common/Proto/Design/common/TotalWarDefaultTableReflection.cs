using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class TotalWarDefaultTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvVG90YWxXYXJfX1/sooXrp5DsnZgg7IScL1RvdGFsV2Fy" + "RGVmYXVsdFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uItoCChRU" + "b3RhbFdhckRlZmF1bHRUYWJsZRIKCgJpZBgBIAEoBRIYChBpZGxlQ2hhbmdl" + "RGFtYWdlGAIgAygFEhYKDnJld2FyZE9iamVjdElkGAMgASgFEioKInJld2Fy" + "ZE9iamVjdEludGVyYWN0aW9uTG9jYWxUZXh0SWQYBCABKAUSHgoWcmV3YXJk" + "T2JqZWN0UHJlZmFiTmFtZRgFIAEoCRIfChd0b3RhbFdhclByZXNldEJhc2VD" + "b3VudBgGIAEoBRIeChZ0b3RhbFdhclByZXNldEJ1eUNvdW50GAcgASgFEhsK" + "E3RvdGFsV2FyUHJlc2V0QnV5SWQYCCABKAUSHQoVdG90YWxXYXJQcmVzZXRC" + "dXlUeXBlGAkgASgFEh4KFnRvdGFsV2FyUHJlc2V0TWF4Q291bnQYCiABKAUS" + "GwoTdG90YWxXYXJTdGFydEJ1ZmZJZBgLIAEoBUJEQhNQcm90by5EZXNpZ24u" + "Y29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2ln" + "bi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarDefaultTable), TotalWarDefaultTable.Parser, new string[11]
		{
			"Id", "IdleChangeDamage", "RewardObjectId", "RewardObjectInteractionLocalTextId", "RewardObjectPrefabName", "TotalWarPresetBaseCount", "TotalWarPresetBuyCount", "TotalWarPresetBuyId", "TotalWarPresetBuyType", "TotalWarPresetMaxCount",
			"TotalWarStartBuffId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
