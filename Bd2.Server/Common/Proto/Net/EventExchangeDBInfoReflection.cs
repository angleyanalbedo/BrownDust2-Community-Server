using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventExchangeDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL0V2ZW50RXhjaGFuZ2VEQkluZm8ucHJvdG8SCXByb3RvLm5ldCJbChNFdmVudEV4Y2hhbmdlREJJbmZvEhEKCWV2ZW50X3VpZBgBIAEoBRIQCghncm91cF9pZBgCIAEoBRIMCgRwYWdlGAMgASgFEhEKCWtleV9jb3VudBgEIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventExchangeDBInfo), EventExchangeDBInfo.Parser, new string[4] { "EventUid", "GroupId", "Page", "KeyCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
