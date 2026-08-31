using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameBoardInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9NaW5pR2FtZUJvYXJkSW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIUNvbW1vbnMvTWluaUdhbWVCb2FyZERCSW5mby5wcm90byJZ" + "ChlNaW5pR2FtZUJvYXJkSW5mb1Jlc3BvbnNlEjwKFG1pbmlfZ2FtZV9ib2Fy" + "ZF9pbmZvGAEgAygLMh4ucHJvdG8ubmV0Lk1pbmlHYW1lQm9hcmREQkluZm9i" + "BnByb3RvMw=="), new FileDescriptor[1] { MiniGameBoardDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameBoardInfoResponse), MiniGameBoardInfoResponse.Parser, new string[1] { "MiniGameBoardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
