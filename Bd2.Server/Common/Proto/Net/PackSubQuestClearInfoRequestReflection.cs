using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackSubQuestClearInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXF1ZXN0L1BhY2tTdWJRdWVzdENsZWFySW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI8ChxQYWNrU3ViUXVlc3RDbGVhckluZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgAygFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackSubQuestClearInfoRequest), PackSubQuestClearInfoRequest.Parser, new string[2] { "Seq", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
