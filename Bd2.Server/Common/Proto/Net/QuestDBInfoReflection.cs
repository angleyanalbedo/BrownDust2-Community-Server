using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDb21tb25zL1F1ZXN0REJJbmZvLnByb3RvEglwcm90by5uZXQiYwoLUXVlc3REQkluZm8SCgoCaWQYASABKAUSDQoFdmFsdWUYAiABKAUSEQoJb2JqZWN0X2lkGAMgAygFEhMKC3F1ZXN0X2xldmVsGAQgASgFEhEKCXF1ZXN0X29wdBgFIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestDBInfo), QuestDBInfo.Parser, new string[5] { "Id", "Value", "ObjectId", "QuestLevel", "QuestOpt" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
