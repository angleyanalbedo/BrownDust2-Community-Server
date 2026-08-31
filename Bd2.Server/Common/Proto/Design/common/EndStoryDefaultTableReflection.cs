using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EndStoryDefaultTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvVHV0b3JpYWxfX1/tipzthqDrpqzslrwvRW5kU3RvcnlE" + "ZWZhdWx0VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ibgoURW5k" + "U3RvcnlEZWZhdWx0VGFibGUSHAoUZW5kR3VpZGVUYWJsZUdyb3VwSUQYASAB" + "KAUSEQoJZW5kUGFja0lkGAIgASgFEhkKEWVuZFBhY2tUdXRvcmlhbElkGAMg" + "ASgFEgoKAmlkGAQgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Q" + "cm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EndStoryDefaultTable), EndStoryDefaultTable.Parser, new string[4] { "EndGuideTableGroupID", "EndPackId", "EndPackTutorialId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
