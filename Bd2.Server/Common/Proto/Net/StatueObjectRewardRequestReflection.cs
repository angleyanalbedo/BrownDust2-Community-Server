using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class StatueObjectRewardRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L1N0YXR1ZU9iamVjdFJld2FyZFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI0ChlTdGF0dWVPYmplY3RSZXdhcmRSZXF1ZXN0EgsKA3NlcRgBIAEoBRIKCgJpZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(StatueObjectRewardRequest), StatueObjectRewardRequest.Parser, new string[2] { "Seq", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
