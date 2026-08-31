using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class StoryLibraryTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9TdG9yeUxpYnJh" + "cnlUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKUAgoRU3RvcnlM" + "aWJyYXJ5VGFibGUSCgoCaWQYASABKAUSEAoIaXNQcm9sb2cYAiABKAUSDQoF" + "bWFwSWQYAyABKAUSDgoGcGFja0lkGAQgASgFEiEKGXF1ZXN0Q29uZGl0aW9u" + "UXVlc3RUZXh0SWQYBSABKAUSHAoUcXVlc3REZXNjUXVlc3RUZXh0SWQYBiAB" + "KAUSFAoMcXVlc3RHcm91cElkGAcgASgFEg8KB3F1ZXN0SWQYCCABKAUSHAoU" + "cXVlc3ROYW1lUXVlc3RUZXh0SWQYCSABKAUSEwoLcXVlc3RUeXBlSWQYCiAB" + "KAUSEQoJc3RvcnlUeXBlGAsgASgFEhQKDHRpbWVsaW5lTmFtZRgMIAEoCUJE" + "QhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1v" + "bqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(StoryLibraryTable), StoryLibraryTable.Parser, new string[12]
		{
			"Id", "IsProlog", "MapId", "PackId", "QuestConditionQuestTextId", "QuestDescQuestTextId", "QuestGroupId", "QuestId", "QuestNameQuestTextId", "QuestTypeId",
			"StoryType", "TimelineName"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
