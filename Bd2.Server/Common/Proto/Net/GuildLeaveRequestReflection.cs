using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildLeaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L0d1aWxkTGVhdmVSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiIAoRR3VpbGRMZWF2ZVJlcXVlc3QSCwoDc2VxGAEgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildLeaveRequest), GuildLeaveRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
