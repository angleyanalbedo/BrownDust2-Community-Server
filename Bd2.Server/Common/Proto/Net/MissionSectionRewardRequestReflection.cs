using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MissionSectionRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXF1ZXN0L01pc3Npb25TZWN0aW9uUmV3YXJkUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IloKG01pc3Npb25TZWN0aW9uUmV3YXJkUmVxdWVzdBILCgNzZXEYASABKAUSEgoKZ3JvdXBfdHlwZRgCIAEoBRIOCgZpc19hbGwYAyABKAgSCgoCaWQYBCABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MissionSectionRewardRequest), MissionSectionRewardRequest.Parser, new string[4] { "Seq", "GroupType", "IsAll", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
