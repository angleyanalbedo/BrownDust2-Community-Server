using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarRewardStateResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9Ub3RhbFdhclJld2FyZFN0YXRlUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCJBChtUb3RhbFdhclJld2FyZFN0YXRlUmVzcG9uc2USIgoaaXNfb2J0YWluYWJsZV9kYWlseV9yZXdhcmQYASABKAhiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarRewardStateResponse), TotalWarRewardStateResponse.Parser, new string[1] { "IsObtainableDailyReward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
