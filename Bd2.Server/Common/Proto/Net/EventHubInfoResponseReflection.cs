using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventHubInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9FdmVudEh1YkluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhxDb21tb25zL0V2ZW50SHViREJJbmZvLnByb3RvIkkKFEV2ZW50SHViSW5mb1Jlc3BvbnNlEjEKDmV2ZW50X2h1Yl9pbmZvGAEgAygLMhkucHJvdG8ubmV0LkV2ZW50SHViREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { EventHubDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventHubInfoResponse), EventHubInfoResponse.Parser, new string[1] { "EventHubInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
