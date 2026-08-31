using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9RdWVzdEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhlDb21tb25zL1F1ZXN0REJJbmZvLnByb3RvIlgKEVF1ZXN0SW5mb1Jlc3BvbnNlEioKCnF1ZXN0X2luZm8YASADKAsyFi5wcm90by5uZXQuUXVlc3REQkluZm8SFwoPY2xlYXJfcXVlc3RfaWRzGAIgAygFYgZwcm90bzM="), new FileDescriptor[1] { QuestDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestInfoResponse), QuestInfoResponse.Parser, new string[2] { "QuestInfo", "ClearQuestIds" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
