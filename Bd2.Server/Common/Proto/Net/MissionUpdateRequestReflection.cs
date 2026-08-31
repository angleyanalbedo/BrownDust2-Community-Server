using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MissionUpdateRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L01pc3Npb25VcGRhdGVSZXF1ZXN0LnByb3RvEglwcm90by5u" + "ZXQiUgoRTWlzc2lvblVwZGF0ZUluZm8SEAoIZ3JvdXBfaWQYASABKAUSCgoC" + "aWQYAiABKAUSDQoFdmFsdWUYAyABKAUSEAoIZXZlbnRfaWQYBCABKAMiVgoU" + "TWlzc2lvblVwZGF0ZVJlcXVlc3QSCwoDc2VxGAEgASgFEjEKC3VwZGF0ZV9p" + "bmZvGAIgAygLMhwucHJvdG8ubmV0Lk1pc3Npb25VcGRhdGVJbmZvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(MissionUpdateInfo), MissionUpdateInfo.Parser, new string[4] { "GroupId", "Id", "Value", "EventId" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(MissionUpdateRequest), MissionUpdateRequest.Parser, new string[2] { "Seq", "UpdateInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
