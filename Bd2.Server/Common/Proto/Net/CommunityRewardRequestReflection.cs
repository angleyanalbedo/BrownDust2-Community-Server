using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CommunityRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0NvbW11bml0eVJld2FyZFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJFChZDb21tdW5pdHlSZXdhcmRSZXF1ZXN0EgsKA3NlcRgBIAEoBRIMCgR0eXBlGAIgASgFEhAKCHN1Yl90eXBlGAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CommunityRewardRequest), CommunityRewardRequest.Parser, new string[3] { "Seq", "Type", "SubType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
