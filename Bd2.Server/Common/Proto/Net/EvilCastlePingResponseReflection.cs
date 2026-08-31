using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastlePingResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9FdmlsQ2FzdGxlUGluZ1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQiJwoWRXZpbENhc3RsZVBpbmdSZXNwb25zZRINCgVwb2ludBgBIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastlePingResponse), EvilCastlePingResponse.Parser, new string[1] { "Point" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
