using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackDetailResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9QYWNrRGV0YWlsUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCJrChJQYWNrRGV0YWlsUmVzcG9uc2USOwoJcGFja19pbmZvGAEgASgLMigucHJvdG8ubmV0LlBhY2tEZXRhaWxSZXNwb25zZS5QYWNrRGV0YWlsGhgKClBhY2tEZXRhaWwSCgoCaWQYASABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackDetailResponse), PackDetailResponse.Parser, new string[1] { "PackInfo" }, null, null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PackDetailResponse.Types.PackDetail), PackDetailResponse.Types.PackDetail.Parser, new string[1] { "Id" }, null, null, null, null)
		})
	}));

	public static FileDescriptor Descriptor => descriptor;
}
