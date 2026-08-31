using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TrapDamageRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L1RyYXBEYW1hZ2VSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiMQoRVHJhcERhbWFnZVJlcXVlc3QSCwoDc2VxGAEgASgFEg8KB3RyYXBfaWQYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TrapDamageRequest), TrapDamageRequest.Parser, new string[2] { "Seq", "TrapId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
