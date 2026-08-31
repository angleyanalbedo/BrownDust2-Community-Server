using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackRewardObjectCountRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXF1ZXN0L1BhY2tSZXdhcmRPYmplY3RDb3VudFJlcXVlc3QucHJvdG8S" + "CXByb3RvLm5ldBoUQ29tbW9ucy9EZWZpbmUucHJvdG8ifQocUGFja1Jld2Fy" + "ZE9iamVjdENvdW50UmVxdWVzdBILCgNzZXEYASABKAUSDwoHcGFja19pZBgC" + "IAMoBRI/Cgpjb3VudF90eXBlGAMgAygOMisucHJvdG8ubmV0LkRlZmluZV9Q" + "YWNrUmV3YXJkT2JqZWN0Q291bnRUeXBlYgZwcm90bzM="), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackRewardObjectCountRequest), PackRewardObjectCountRequest.Parser, new string[3] { "Seq", "PackId", "CountType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
