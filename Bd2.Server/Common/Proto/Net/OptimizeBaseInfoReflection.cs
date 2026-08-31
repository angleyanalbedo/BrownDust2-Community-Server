using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class OptimizeBaseInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL09wdGltaXplQmFzZUluZm8ucHJvdG8SCXByb3RvLm5ldCJdChBPcHRpbWl6ZUJhc2VJbmZvEhYKDm9wdGltaXplX2luZGV4GAEgASgFEhYKDm9wdGltaXplX3ZhbHVlGAIgASgIEhkKEW9wdGltaXplX3Byb3BlcnR5GAMgASgJYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(OptimizeBaseInfo), OptimizeBaseInfo.Parser, new string[3] { "OptimizeIndex", "OptimizeValue", "OptimizeProperty" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
