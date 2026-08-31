using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class QuestClearIllustTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvUXVlc3RUYWJsZV9fX+2AmOyKpO2KuC9RdWVzdENsZWFy" + "SWxsdXN0VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iSAoVUXVl" + "c3RDbGVhcklsbHVzdFRhYmxlEg8KB2dyb3VwSWQYASABKAUSCgoCaWQYAiAB" + "KAUSEgoKaWxsdXN0TmFtZRgDIAEoCUJEQhNQcm90by5EZXNpZ24uY29tbW9u" + "UAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21t" + "b25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestClearIllustTable), QuestClearIllustTable.Parser, new string[3] { "GroupId", "Id", "IllustName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
