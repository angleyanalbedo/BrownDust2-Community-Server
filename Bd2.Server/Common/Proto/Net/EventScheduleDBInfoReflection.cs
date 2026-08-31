using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventScheduleDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL0V2ZW50U2NoZWR1bGVEQkluZm8ucHJvdG8SCXByb3RvLm5l" + "dBoUQ29tbW9ucy9EZWZpbmUucHJvdG8ioAEKE0V2ZW50U2NoZWR1bGVEQklu" + "Zm8SCgoCaWQYASABKAUSLwoKZXZlbnRfdHlwZRgCIAEoDjIbLnByb3RvLm5l" + "dC5EZWZpbmVfRXZlbnRUeXBlEhAKCGV2ZW50X2lkGAMgASgFEhQKDGV2ZW50" + "X3N1Yl9pZBgEIAEoBRISCgpzdGFydF9kYXRlGAUgASgDEhAKCGVuZF9kYXRl" + "GAYgASgDYgZwcm90bzM="), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventScheduleDBInfo), EventScheduleDBInfo.Parser, new string[6] { "Id", "EventType", "EventId", "EventSubId", "StartDate", "EndDate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
