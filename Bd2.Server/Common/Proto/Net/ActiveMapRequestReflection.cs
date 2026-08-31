using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ActiveMapRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L0FjdGl2ZU1hcFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJVChBBY3RpdmVNYXBSZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgASgFEg4KBm1hcF9pZBgDIAEoBRITCgthY3RpdmVfaW5mbxgEIAMoCWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ActiveMapRequest), ActiveMapRequest.Parser, new string[4] { "Seq", "PackId", "MapId", "ActiveInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
