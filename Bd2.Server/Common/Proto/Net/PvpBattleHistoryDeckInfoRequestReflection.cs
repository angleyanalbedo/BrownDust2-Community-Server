using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleHistoryDeckInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXF1ZXN0L1B2cEJhdHRsZUhpc3RvcnlEZWNrSW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJECh9QdnBCYXR0bGVIaXN0b3J5RGVja0luZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBRIUCgxiYXR0bGVfaW5kZXgYAiABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleHistoryDeckInfoRequest), PvpBattleHistoryDeckInfoRequest.Parser, new string[2] { "Seq", "BattleIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
