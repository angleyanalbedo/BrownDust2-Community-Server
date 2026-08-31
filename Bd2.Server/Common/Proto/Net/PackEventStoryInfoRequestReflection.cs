using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackEventStoryInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L1BhY2tFdmVudFN0b3J5SW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI7ChlQYWNrRXZlbnRTdG9yeUluZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBRIRCglldmVudF91aWQYAiADKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventStoryInfoRequest), PackEventStoryInfoRequest.Parser, new string[2] { "Seq", "EventUid" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
