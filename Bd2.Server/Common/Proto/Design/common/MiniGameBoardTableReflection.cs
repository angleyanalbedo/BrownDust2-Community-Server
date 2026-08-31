using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MiniGameBoardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvTWluaUdhbWVfX1/rr7jri4gg6rKM7J6EL01pbmlHYW1l" + "Qm9hcmRUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKcAgoSTWlu" + "aUdhbWVCb2FyZFRhYmxlEhUKDWJvYXJkVWlQcmVmYWIYASABKAkSGgoSY2hh" + "clNwcml0ZVJlc291cmNlGAIgASgFEgoKAmlkGAMgASgFEhEKCWl0ZW1Db3Vu" + "dBgEIAEoBRIOCgZpdGVtSWQYBSABKAUSEAoIaXRlbVR5cGUYBiABKAUSJQod" + "bWluaUdhbWVDb21wbGV0ZVJld2FyZEdyb3VwSWQYByABKAUSIAoYbWluaUdh" + "bWVUaXRsZUxvY2FsVGV4dElkGAggASgFEh0KFW1vdmVDb250cm9sbGVyR3Jv" + "dXBJZBgJIAEoBRIRCglwbGF5U3BlZWQYCiABKAUSFwoPc2NhZmZvbGRHcm91" + "cElkGAsgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5E" + "ZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBoardTable), MiniGameBoardTable.Parser, new string[11]
		{
			"BoardUiPrefab", "CharSpriteResource", "Id", "ItemCount", "ItemId", "ItemType", "MiniGameCompleteRewardGroupId", "MiniGameTitleLocalTextId", "MoveControllerGroupId", "PlaySpeed",
			"ScaffoldGroupId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
