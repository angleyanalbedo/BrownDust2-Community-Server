using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RandomBoxTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL1JhbmRvbUJveFRh" + "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIv0BCg5SYW5kb21Cb3hU" + "YWJsZRIQCghkcm9wVHlwZRgBIAEoBRINCgVncmFkZRgCIAEoBRIWCg5pY29u" + "U3ByaXRlTmFtZRgDIAEoCRIKCgJpZBgEIAEoBRIVCg1pdGVtQWNxdWlyZUlk" + "GAUgAygFEh8KF2l0ZW1EZXNjUmFuZG9tQm94VGV4dElkGAYgASgFEh8KF2l0" + "ZW1OYW1lUmFuZG9tQm94VGV4dElkGAcgASgFEhAKCG5vdFRyYXNoGAggASgF" + "EhUKDXJld2FyZEdyb3VwSWQYCSABKAUSEAoIc29ydFR5cGUYCiABKAUSEgoK" + "c3RhY2tDb3VudBgLIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4v" + "UHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RandomBoxTable), RandomBoxTable.Parser, new string[11]
		{
			"DropType", "Grade", "IconSpriteName", "Id", "ItemAcquireId", "ItemDescRandomBoxTextId", "ItemNameRandomBoxTextId", "NotTrash", "RewardGroupId", "SortType",
			"StackCount"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
