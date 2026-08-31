using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MissionClearRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L01pc3Npb25DbGVhclJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJ2ChNNaXNzaW9uQ2xlYXJSZXF1ZXN0EgsKA3NlcRgBIAEoBRIOCgZpc19hbGwYAiABKAgSEgoKZ3JvdXBfdHlwZRgDIAEoBRIQCghncm91cF9pZBgEIAEoBRIKCgJpZBgFIAEoBRIQCghldmVudF9pZBgGIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MissionClearRequest), MissionClearRequest.Parser, new string[6] { "Seq", "IsAll", "GroupType", "GroupId", "Id", "EventId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
