using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ContentOpenTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkBjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9D" + "b250ZW50T3BlblRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIooB" + "ChBDb250ZW50T3BlblRhYmxlEg8KB2dyb3VwSWQYASABKAUSCgoCaWQYAiAB" + "KAUSGwoTb3BlbkhlbHBMb2NhbFRleHRJZBgDIAEoBRIWCg5vcGVuVHV0b3Jp" + "YWxJZBgEIAEoBRISCgpzcXVhZExldmVsGAUgASgFEhAKCHRpY2tldElkGAYg" + "ASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24u" + "Y29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ContentOpenTable), ContentOpenTable.Parser, new string[6] { "GroupId", "Id", "OpenHelpLocalTextId", "OpenTutorialId", "SquadLevel", "TicketId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
