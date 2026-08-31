using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestGiveUpRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L1F1ZXN0R2l2ZVVwUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkQKElF1ZXN0R2l2ZVVwUmVxdWVzdBILCgNzZXEYASABKAUSEAoIcXVlc3RfaWQYAiABKAUSDwoHcGFja19pZBgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestGiveUpRequest), QuestGiveUpRequest.Parser, new string[3] { "Seq", "QuestId", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
