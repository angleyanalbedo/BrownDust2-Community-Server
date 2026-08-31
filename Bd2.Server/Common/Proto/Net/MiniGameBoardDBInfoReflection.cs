using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameBoardDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL01pbmlHYW1lQm9hcmREQkluZm8ucHJvdG8SCXByb3RvLm5l" + "dCJ4ChNNaW5pR2FtZUJvYXJkREJJbmZvEhkKEWV2ZW50X3NjaGVkdWxlX2lk" + "GAEgASgFEhkKEXNjYWZmb2xkX2dyb3VwX2lkGAIgASgFEhMKC3NjYWZmb2xk" + "X2lkGAMgASgFEhYKDmNvbXBsZXRlX2NvdW50GAQgASgFIjcKGk1pbmlHYW1l" + "TW92ZUNvbnRyb2xsZXJJbmZvEgoKAmlkGAEgASgFEg0KBXZhbHVlGAIgASgF" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBoardDBInfo), MiniGameBoardDBInfo.Parser, new string[4] { "EventScheduleId", "ScaffoldGroupId", "ScaffoldId", "CompleteCount" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(MiniGameMoveControllerInfo), MiniGameMoveControllerInfo.Parser, new string[2] { "Id", "Value" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
