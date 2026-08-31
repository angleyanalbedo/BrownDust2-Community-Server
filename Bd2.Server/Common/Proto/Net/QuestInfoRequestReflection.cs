using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L1F1ZXN0SW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCIwChBRdWVzdEluZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestInfoRequest), QuestInfoRequest.Parser, new string[2] { "Seq", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
