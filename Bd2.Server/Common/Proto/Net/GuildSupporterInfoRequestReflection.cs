using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildSupporterInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L0d1aWxkU3VwcG9ydGVySW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJYChlHdWlsZFN1cHBvcnRlckluZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBRIaChJtZW1iZXJfb3duZXJfaW5kZXgYAiABKAMSEgoKc2xvdF9pbmRleBgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildSupporterInfoRequest), GuildSupporterInfoRequest.Parser, new string[3] { "Seq", "MemberOwnerIndex", "SlotIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
