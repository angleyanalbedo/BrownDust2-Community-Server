using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackEventStoryTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L1BhY2tFdmVudFN0" + "b3J5VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24imAIKE1BhY2tF" + "dmVudFN0b3J5VGFibGUSDwoHZ3JvdXBJZBgBIAEoBRIKCgJpZBgCIAEoBRIN" + "CgVtYXBJZBgDIAEoBRIOCgZwYWNrSWQYBCABKAUSIQoZcXVlc3RDb25kaXRp" + "b25RdWVzdFRleHRJZBgFIAEoBRIUCgxxdWVzdEdyb3VwSWQYBiABKAUSHAoU" + "cXVlc3ROYW1lUXVlc3RUZXh0SWQYByABKAUSHQoVcXVlc3RUaXRsZVF1ZXN0" + "VGV4dElkGAggASgFEhMKC3Jld2FyZENvdW50GAkgAygFEhAKCHJld2FyZElk" + "GAogAygFEhIKCnJld2FyZFR5cGUYCyADKAUSFAoMdGltZWxpbmVOYW1lGAwg" + "ASgJQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24u" + "Y29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventStoryTable), PackEventStoryTable.Parser, new string[12]
		{
			"GroupId", "Id", "MapId", "PackId", "QuestConditionQuestTextId", "QuestGroupId", "QuestNameQuestTextId", "QuestTitleQuestTextId", "RewardCount", "RewardId",
			"RewardType", "TimelineName"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
