using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class NoticeDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb21tb25zL05vdGljZURCSW5mby5wcm90bxIJcHJvdG8ubmV0GhRDb21t" + "b25zL0RlZmluZS5wcm90byJXChJOb3RpY2VDb250ZW50c0luZm8SMgoEdHlw" + "ZRgBIAEoDjIkLnByb3RvLm5ldC5EZWZpbmVfTm90aWNlQ29udGVudHNUeXBl" + "Eg0KBXZhbHVlGAIgASgJIrACCgxOb3RpY2VEQkluZm8SCgoCaWQYASABKAUS" + "MQoLbm90aWNlX3R5cGUYAiABKA4yHC5wcm90by5uZXQuRGVmaW5lX05vdGlj" + "ZVR5cGUSDQoFdGl0bGUYAyABKAkSEQoJdGh1bWJuYWlsGAQgASgJEhIKCnN0" + "YXJ0X3RpbWUYBSABKAMSEAoIZW5kX3RpbWUYBiABKAMSDwoHd2ViX3VybBgH" + "IAEoCRI7ChRub3RpY2VfY29udGVudHNfaW5mbxgIIAMoCzIdLnByb3RvLm5l" + "dC5Ob3RpY2VDb250ZW50c0luZm8SGwoTcHJvbW90aW9uX2Jhbm5lcl9pZBgJ" + "IAEoBRIOCgZpc19waW4YCiABKAgSDAoEc29ydBgLIAEoBRIQCghzdWJfdHlw" + "ZRgMIAEoBWIGcHJvdG8z"), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(NoticeContentsInfo), NoticeContentsInfo.Parser, new string[2] { "Type", "Value" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(NoticeDBInfo), NoticeDBInfo.Parser, new string[12]
		{
			"Id", "NoticeType", "Title", "Thumbnail", "StartTime", "EndTime", "WebUrl", "NoticeContentsInfo", "PromotionBannerId", "IsPin",
			"Sort", "SubType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
