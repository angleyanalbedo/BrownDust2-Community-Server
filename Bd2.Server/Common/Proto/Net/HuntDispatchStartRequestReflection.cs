using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntDispatchStartRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0h1bnREaXNwYXRjaFN0YXJ0UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0InAKGEh1bnREaXNwYXRjaFN0YXJ0UmVxdWVzdBILCgNzZXEYASABKAUSHgoWaHVudF9kaXNwYXRjaF9ncm91cF9pZBgCIAEoBRIYChBodW50X2Rpc3BhdGNoX2lkGAMgASgFEg0KBWNvdW50GAQgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchStartRequest), HuntDispatchStartRequest.Parser, new string[4] { "Seq", "HuntDispatchGroupId", "HuntDispatchId", "Count" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
