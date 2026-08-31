using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldScoreRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L01pbmlHYW1lRmllbGRTY29yZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJWChlNaW5pR2FtZUZpZWxkU2NvcmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRIZChFldmVudF9zY2hlZHVsZV9pZBgCIAEoBRIRCglvYmplY3RfaWQYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldScoreRequest), MiniGameFieldScoreRequest.Parser, new string[3] { "Seq", "EventScheduleId", "ObjectId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
