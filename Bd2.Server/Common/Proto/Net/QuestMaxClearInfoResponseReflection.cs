using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestMaxClearInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9RdWVzdE1heENsZWFySW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaIUNvbW1vbnMvUXVlc3RNYXhDbGVhckRCSW5mby5wcm90byJT" + "ChlRdWVzdE1heENsZWFySW5mb1Jlc3BvbnNlEjYKDm1heF9jbGVhcl9pbmZv" + "GAEgAygLMh4ucHJvdG8ubmV0LlF1ZXN0TWF4Q2xlYXJEQkluZm9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { QuestMaxClearDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestMaxClearInfoResponse), QuestMaxClearInfoResponse.Parser, new string[1] { "MaxClearInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
