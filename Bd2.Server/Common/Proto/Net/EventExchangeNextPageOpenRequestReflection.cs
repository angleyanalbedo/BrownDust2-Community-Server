using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventExchangeNextPageOpenRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXF1ZXN0L0V2ZW50RXhjaGFuZ2VOZXh0UGFnZU9wZW5SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiVAogRXZlbnRFeGNoYW5nZU5leHRQYWdlT3BlblJlcXVlc3QSCwoDc2VxGAEgASgFEhEKCWV2ZW50X3VpZBgCIAEoBRIQCghncm91cF9pZBgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventExchangeNextPageOpenRequest), EventExchangeNextPageOpenRequest.Parser, new string[3] { "Seq", "EventUid", "GroupId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
