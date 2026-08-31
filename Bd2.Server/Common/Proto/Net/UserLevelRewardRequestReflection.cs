using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UserLevelRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L1VzZXJMZXZlbFJld2FyZFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCIxChZVc2VyTGV2ZWxSZXdhcmRSZXF1ZXN0EgsKA3NlcRgBIAEoBRIKCgJpZBgCIAMoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserLevelRewardRequest), UserLevelRewardRequest.Parser, new string[2] { "Seq", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
