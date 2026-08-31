using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleGridTypeItemDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZDb21tb25zL0JhdHRsZUdyaWRUeXBlSXRlbURCSW5mby5wcm90bxIJcHJv" + "dG8ubmV0InoKGEJhdHRsZUdyaWRUeXBlSXRlbURCSW5mbxIRCgl0ZWFtX3R5" + "cGUYASABKAUSEgoKZ3JpZF9pbmRleBgCIAEoBRIPCgdidWZmX2lkGAMgASgF" + "EhMKC2lzX2luZmluaXRlGAQgASgIEhEKCWJ1ZmZfdHVybhgFIAEoBWIGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleGridTypeItemDBInfo), BattleGridTypeItemDBInfo.Parser, new string[5] { "TeamType", "GridIndex", "BuffId", "IsInfinite", "BuffTurn" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
