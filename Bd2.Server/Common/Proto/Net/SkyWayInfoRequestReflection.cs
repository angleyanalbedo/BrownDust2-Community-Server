using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SkyWayInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L1NreVdheUluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiMQoRU2t5V2F5SW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFEg8KB3BhY2tfaWQYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkyWayInfoRequest), SkyWayInfoRequest.Parser, new string[2] { "Seq", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
