using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class InnOpenResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXNwb25zZS9Jbm5PcGVuUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldCIrCg9Jbm5PcGVuUmVzcG9uc2USGAoQcmVwdXRhdGlvbl9zdGF0ZRgBIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(InnOpenResponse), InnOpenResponse.Parser, new string[1] { "ReputationState" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
