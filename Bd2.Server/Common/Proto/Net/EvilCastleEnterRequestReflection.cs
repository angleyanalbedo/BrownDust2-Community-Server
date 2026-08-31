using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleEnterRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0V2aWxDYXN0bGVFbnRlclJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJdChZFdmlsQ2FzdGxlRW50ZXJSZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgASgFEhMKC3N0YWdlX2luZGV4GAMgASgFEhAKCGlzX3JldHJ5GAQgASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleEnterRequest), EvilCastleEnterRequest.Parser, new string[4] { "Seq", "PackId", "StageIndex", "IsRetry" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
