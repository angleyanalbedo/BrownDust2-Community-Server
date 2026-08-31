using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L01pbmlHYW1lRmllbGRSZXdhcmRSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiRAoaTWluaUdhbWVGaWVsZFJld2FyZFJlcXVlc3QSCwoDc2VxGAEgASgFEhkKEWV2ZW50X3NjaGVkdWxlX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldRewardRequest), MiniGameFieldRewardRequest.Parser, new string[2] { "Seq", "EventScheduleId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
