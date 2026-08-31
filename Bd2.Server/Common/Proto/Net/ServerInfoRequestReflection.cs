using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ServerInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L1NlcnZlckluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiIAoRU2VydmVySW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ServerInfoRequest), ServerInfoRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
