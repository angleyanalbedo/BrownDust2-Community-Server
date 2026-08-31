using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildJoinRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L0d1aWxkSm9pblJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCIrChBHdWlsZEpvaW5SZXF1ZXN0EgsKA3NlcRgBIAEoBRIKCgJpZBgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildJoinRequest), GuildJoinRequest.Parser, new string[2] { "Seq", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
