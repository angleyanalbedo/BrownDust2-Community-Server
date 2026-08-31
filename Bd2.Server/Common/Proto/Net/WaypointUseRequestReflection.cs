using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class WaypointUseRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L1dheXBvaW50VXNlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0InoKEldheXBvaW50VXNlUmVxdWVzdBILCgNzZXEYASABKAUSDwoHcGFja19pZBgCIAEoBRIZChFzdGFydF93YXlwb2ludF9pZBgDIAEoBRIXCg9lbmRfd2F5cG9pbnRfaWQYBCABKAUSEgoKbW92ZV9wb2ludBgFIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(WaypointUseRequest), WaypointUseRequest.Parser, new string[5] { "Seq", "PackId", "StartWaypointId", "EndWaypointId", "MovePoint" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
