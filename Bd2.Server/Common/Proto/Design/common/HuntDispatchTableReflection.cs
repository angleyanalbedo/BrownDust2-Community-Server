using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class HuntDispatchTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvSHVudERpc3BhdGNoX19f7IKs64OlIOydmOuisC9IdW50" + "RGlzcGF0Y2hUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLnAgoR" + "SHVudERpc3BhdGNoVGFibGUSEQoJYXBQZXJUaW1lGAEgASgFEhcKD2JhdHRs" + "ZUNvdW50Qm9zcxgCIAEoBRIaChJiYXR0bGVDb3VudE1vbnN0ZXIYAyABKAUS" + "EQoJY2xlYXJUaW1lGAQgASgFEhIKCmRpZmZpY3VsdHkYBSABKAUSGgoSZGlz" + "cGF0Y2hOYW1lVGV4dElkGAYgASgFEg8KB2dyb3VwSWQYByABKAUSCgoCaWQY" + "CCABKAUSFQoNbWFwVWlPYmplY3RJZBgJIAEoBRIOCgZwYWNrSWQYCiABKAUS" + "FgoOcGFja05hbWVUZXh0SWQYCyABKAUSGAoQcmV3YXJkR3Jvd3RoUmF0ZRgM" + "IAEoBRITCgt0eXBlR3JvdXBJZBgNIAEoBRIOCgZ0eXBlSWQYDiABKAUSFAoM" + "dmlzdWFsSXRlbUlkGA8gAygFEhYKDnZpc3VhbEl0ZW1UeXBlGBAgAygFQkRC" + "E1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9u" + "qgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchTable), HuntDispatchTable.Parser, new string[16]
		{
			"ApPerTime", "BattleCountBoss", "BattleCountMonster", "ClearTime", "Difficulty", "DispatchNameTextId", "GroupId", "Id", "MapUiObjectId", "PackId",
			"PackNameTextId", "RewardGrowthRate", "TypeGroupId", "TypeId", "VisualItemId", "VisualItemType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
