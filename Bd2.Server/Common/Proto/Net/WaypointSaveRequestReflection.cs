using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class WaypointSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L1dheXBvaW50U2F2ZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJIChNXYXlwb2ludFNhdmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgASgFEhMKC3dheXBvaW50X2lkGAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(WaypointSaveRequest), WaypointSaveRequest.Parser, new string[3] { "Seq", "PackId", "WaypointId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
