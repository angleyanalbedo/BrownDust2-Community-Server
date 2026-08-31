using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EventMissionGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0V2ZW50TWlzc2lv" + "bkdyb3VwVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i4wEKFkV2" + "ZW50TWlzc2lvbkdyb3VwVGFibGUSGAoQZXZlbnRNaXNzaW9uVHlwZRgBIAEo" + "BRIXCg9ldmVudE5hbWVUZXh0SWQYAiABKAUSHAoUZ3VpZGVEZXNjTG9jYWxU" + "ZXh0SWQYAyADKAUSHQoVZ3VpZGVUaXRsZUxvY2FsVGV4dElkGAQgAygFEgoK" + "AmlkGAUgASgFEhYKDm1pc3Npb25Hcm91cElkGAYgAygFEhQKDHNjaGVkdWxl" + "VHlwZRgHIAEoBRIOCgZzb3J0SWQYCCABKAUSDwoHdXNlUGFzcxgJIAEoBUJE" + "QhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1v" + "bqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventMissionGroupTable), EventMissionGroupTable.Parser, new string[9] { "EventMissionType", "EventNameTextId", "GuideDescLocalTextId", "GuideTitleLocalTextId", "Id", "MissionGroupId", "ScheduleType", "SortId", "UsePass" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
