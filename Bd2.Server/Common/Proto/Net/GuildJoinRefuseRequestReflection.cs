using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildJoinRefuseRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0d1aWxkSm9pblJlZnVzZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI6ChZHdWlsZEpvaW5SZWZ1c2VSZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgtvd25lcl9pbmRleBgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildJoinRefuseRequest), GuildJoinRefuseRequest.Parser, new string[2] { "Seq", "OwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
