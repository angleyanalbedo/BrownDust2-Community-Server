using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TodayQuestInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9Ub2RheVF1ZXN0SW5mb1Jlc3BvbnNlLnByb3RvEglwcm90" + "by5uZXQaGUNvbW1vbnMvUXVlc3REQkluZm8ucHJvdG8ijQEKFlRvZGF5UXVl" + "c3RJbmZvUmVzcG9uc2USKgoKcXVlc3RfaW5mbxgBIAMoCzIWLnByb3RvLm5l" + "dC5RdWVzdERCSW5mbxIXCg9jbGVhcl9xdWVzdF9pZHMYAiADKAUSFgoOdG9k" + "YXlfZW5kX3RpbWUYAyABKAMSFgoOdG9kYXlfcXVlc3RfaWQYBCADKAViBnBy" + "b3RvMw=="), new FileDescriptor[1] { QuestDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TodayQuestInfoResponse), TodayQuestInfoResponse.Parser, new string[4] { "QuestInfo", "ClearQuestIds", "TodayEndTime", "TodayQuestId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
