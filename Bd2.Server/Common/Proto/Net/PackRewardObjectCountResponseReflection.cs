using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackRewardObjectCountResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXNwb25zZS9QYWNrUmV3YXJkT2JqZWN0Q291bnRSZXNwb25zZS5wcm90" + "bxIJcHJvdG8ubmV0GhRDb21tb25zL0RlZmluZS5wcm90byJZCh1QYWNrUmV3" + "YXJkT2JqZWN0Q291bnRSZXNwb25zZRI4Cgpjb3VudF9pbmZvGAEgAygLMiQu" + "cHJvdG8ubmV0LlBhY2tSZXdhcmRPYmplY3RDb3VudEluZm8iiQEKGVBhY2tS" + "ZXdhcmRPYmplY3RDb3VudEluZm8SOQoEdHlwZRgBIAEoDjIrLnByb3RvLm5l" + "dC5EZWZpbmVfUGFja1Jld2FyZE9iamVjdENvdW50VHlwZRIPCgdwYWNrX2lk" + "GAIgASgFEg0KBWNvdW50GAMgASgFEhEKCW1heF9jb3VudBgEIAEoBWIGcHJv" + "dG8z"), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(PackRewardObjectCountResponse), PackRewardObjectCountResponse.Parser, new string[1] { "CountInfo" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(PackRewardObjectCountInfo), PackRewardObjectCountInfo.Parser, new string[4] { "Type", "PackId", "Count", "MaxCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
