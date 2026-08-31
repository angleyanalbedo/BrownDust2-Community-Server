using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class DelayedVisibilityScheduleDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1Db21tb25zL0RlbGF5ZWRWaXNpYmlsaXR5U2NoZWR1bGVEQkluZm8ucHJv" + "dG8SCXByb3RvLm5ldBoUQ29tbW9ucy9EZWZpbmUucHJvdG8iiQEKH0RlbGF5" + "ZWRWaXNpYmlsaXR5U2NoZWR1bGVEQkluZm8SNQoEdHlwZRgBIAEoDjInLnBy" + "b3RvLm5ldC5EZWZpbmVfRGVsYXllZFZpc2liaWxpdHlUeXBlEgoKAmlkGAIg" + "ASgFEhAKCHRhYmxlX2lkGAMgASgFEhEKCW9wZW5fZGF0ZRgEIAEoA2IGcHJv" + "dG8z"), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(DelayedVisibilityScheduleDBInfo), DelayedVisibilityScheduleDBInfo.Parser, new string[4] { "Type", "Id", "TableId", "OpenDate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
