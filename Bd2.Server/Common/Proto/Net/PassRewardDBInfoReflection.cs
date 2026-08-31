using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PassRewardDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL1Bhc3NSZXdhcmREQkluZm8ucHJvdG8SCXByb3RvLm5ldCJRChBQYXNzUmV3YXJkREJJbmZvEg8KB3Bhc3NfaWQYASABKAUSCgoCaWQYAiABKAUSDQoFYmFzaWMYAyABKAgSEQoJcHJlbWl1bV8xGAQgASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassRewardDBInfo), PassRewardDBInfo.Parser, new string[4] { "PassId", "Id", "Basic", "Premium1" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
