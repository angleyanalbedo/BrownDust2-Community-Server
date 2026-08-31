using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameBingoInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9NaW5pR2FtZUJpbmdvSW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIUNvbW1vbnMvTWluaUdhbWVCaW5nb0RCSW5mby5wcm90byJZ" + "ChlNaW5pR2FtZUJpbmdvSW5mb1Jlc3BvbnNlEjwKFG1pbmlfZ2FtZV9iaW5n" + "b19pbmZvGAEgAygLMh4ucHJvdG8ubmV0Lk1pbmlHYW1lQmluZ29EQkluZm9i" + "BnByb3RvMw=="), new FileDescriptor[1] { MiniGameBingoDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBingoInfoResponse), MiniGameBingoInfoResponse.Parser, new string[1] { "MiniGameBingoInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
