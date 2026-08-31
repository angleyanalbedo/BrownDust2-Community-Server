using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MapActiveInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDb21tb25zL01hcEFjdGl2ZUluZm8ucHJvdG8SCXByb3RvLm5ldCI0Cg1NYXBBY3RpdmVJbmZvEg4KBm1hcF9pZBgBIAEoBRITCgthY3RpdmVfaW5mbxgCIAMoCWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MapActiveInfo), MapActiveInfo.Parser, new string[2] { "MapId", "ActiveInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
