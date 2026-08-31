using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestMaxClearDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL1F1ZXN0TWF4Q2xlYXJEQkluZm8ucHJvdG8SCXByb3RvLm5ldCI8ChNRdWVzdE1heENsZWFyREJJbmZvEg8KB3BhY2tfaWQYASABKAUSFAoMbWF4X2NsZWFyX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestMaxClearDBInfo), QuestMaxClearDBInfo.Parser, new string[2] { "PackId", "MaxClearId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
