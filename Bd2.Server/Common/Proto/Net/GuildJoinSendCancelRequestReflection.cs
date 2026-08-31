using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildJoinSendCancelRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L0d1aWxkSm9pblNlbmRDYW5jZWxSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiNQoaR3VpbGRKb2luU2VuZENhbmNlbFJlcXVlc3QSCwoDc2VxGAEgASgFEgoKAmlkGAIgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildJoinSendCancelRequest), GuildJoinSendCancelRequest.Parser, new string[2] { "Seq", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
