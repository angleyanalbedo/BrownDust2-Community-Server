using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRankingInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXF1ZXN0L0V2aWxDYXN0bGVSYW5raW5nSW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJhChxFdmlsQ2FzdGxlUmFua2luZ0luZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgASgFEg4KBnNlYXNvbhgDIAEoBRITCgtzdGFnZV9pbmRleBgEIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRankingInfoRequest), EvilCastleRankingInfoRequest.Parser, new string[4] { "Seq", "PackId", "Season", "StageIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
