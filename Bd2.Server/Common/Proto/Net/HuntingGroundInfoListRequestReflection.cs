using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntingGroundInfoListRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXF1ZXN0L0h1bnRpbmdHcm91bmRJbmZvTGlzdFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI8ChxIdW50aW5nR3JvdW5kSW5mb0xpc3RSZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgAygFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntingGroundInfoListRequest), HuntingGroundInfoListRequest.Parser, new string[2] { "Seq", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
