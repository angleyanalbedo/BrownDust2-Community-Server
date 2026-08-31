using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldQuickRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXF1ZXN0L01pbmlHYW1lRmllbGRRdWlja1Jld2FyZFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJJCh9NaW5pR2FtZUZpZWxkUXVpY2tSZXdhcmRSZXF1ZXN0EgsKA3NlcRgBIAEoBRIZChFldmVudF9zY2hlZHVsZV9pZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldQuickRewardRequest), MiniGameFieldQuickRewardRequest.Parser, new string[2] { "Seq", "EventScheduleId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
