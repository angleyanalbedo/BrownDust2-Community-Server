using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PingCheckRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L1BpbmdDaGVja1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCISChBQaW5nQ2hlY2tSZXF1ZXN0YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PingCheckRequest), PingCheckRequest.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
