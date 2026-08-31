using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestTitleDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL1F1ZXN0VGl0bGVEQkluZm8ucHJvdG8SCXByb3RvLm5ldCI6ChBRdWVzdFRpdGxlREJJbmZvEhAKCHRpdGxlX2lkGAEgASgFEhQKDG1heF9jbGVhcl9pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestTitleDBInfo), QuestTitleDBInfo.Parser, new string[2] { "TitleId", "MaxClearId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
