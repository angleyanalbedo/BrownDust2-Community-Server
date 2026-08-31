using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventExchangeRewardDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL0V2ZW50RXhjaGFuZ2VSZXdhcmREQkluZm8ucHJvdG8SCXByb3RvLm5ldCJbChlFdmVudEV4Y2hhbmdlUmV3YXJkREJJbmZvEhEKCWV2ZW50X3VpZBgBIAEoBRIQCghncm91cF9pZBgCIAEoBRIKCgJpZBgDIAEoBRINCgVjb3VudBgEIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventExchangeRewardDBInfo), EventExchangeRewardDBInfo.Parser, new string[4] { "EventUid", "GroupId", "Id", "Count" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
