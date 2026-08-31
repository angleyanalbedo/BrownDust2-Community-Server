using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class AlchemyPictorialBookTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkBjb21tb24uZGIvUGljdG9yaWFsQm9va19fX+uPhOqwkC9BbGNoZW15UGlj" + "dG9yaWFsQm9va1RhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIkkK" + "GUFsY2hlbXlQaWN0b3JpYWxCb29rVGFibGUSEAoIY2F0ZWdvcnkYASABKAUS" + "CgoCaWQYAiABKAUSDgoGaXRlbUlkGAMgASgFQkRCE1Byb3RvLkRlc2lnbi5j" + "b21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWdu" + "LmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AlchemyPictorialBookTable), AlchemyPictorialBookTable.Parser, new string[3] { "Category", "Id", "ItemId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
