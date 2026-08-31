using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntingGroundEnterRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L0h1bnRpbmdHcm91bmRFbnRlclJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJlChlIdW50aW5nR3JvdW5kRW50ZXJSZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgASgFEhkKEWh1bnRpbmdfZ3JvdW5kX2lkGAMgASgFEg8KB2lzX2F1dG8YBSABKAhiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntingGroundEnterRequest), HuntingGroundEnterRequest.Parser, new string[4] { "Seq", "PackId", "HuntingGroundId", "IsAuto" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
