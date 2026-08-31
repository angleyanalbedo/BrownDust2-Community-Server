using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuestUpdateRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L1F1ZXN0VXBkYXRlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IlkKElF1ZXN0VXBkYXRlUmVxdWVzdBILCgNzZXEYASABKAUSEAoIcXVlc3RfaWQYAiABKAUSDwoHcGFja19pZBgDIAEoBRITCgtxdWVzdF92YWx1ZRgEIAMoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuestUpdateRequest), QuestUpdateRequest.Parser, new string[4] { "Seq", "QuestId", "PackId", "QuestValue" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
