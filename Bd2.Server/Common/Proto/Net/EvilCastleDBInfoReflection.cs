using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL0V2aWxDYXN0bGVEQkluZm8ucHJvdG8SCXByb3RvLm5ldCKg" + "AQoQRXZpbENhc3RsZURCSW5mbxIMCgRyYW5rGAEgASgFEhMKC3N0YWdlX2lu" + "ZGV4GAIgASgFEg0KBXJldHJ5GAMgASgFEg0KBXBvaW50GAQgASgFEhwKFHNl" + "YXNvbl9oaWdoZXN0X3BvaW50GAUgASgFEhMKC2lzX3Jld2FyZGVkGAYgASgI" + "EhgKEHN0YWdlX2NsZWFyX3RpbWUYByABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleDBInfo), EvilCastleDBInfo.Parser, new string[7] { "Rank", "StageIndex", "Retry", "Point", "SeasonHighestPoint", "IsRewarded", "StageClearTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
