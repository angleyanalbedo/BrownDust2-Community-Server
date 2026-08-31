using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharSpecialScoutBuyResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9DaGFyU3BlY2lhbFNjb3V0QnV5UmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldBogQ29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8i" + "WAobQ2hhclNwZWNpYWxTY291dEJ1eVJlc3BvbnNlEjkKEnJld2FyZF9pbmZv" + "X2J1bmRsZRgBIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQkluZm9CdW5kbGVi" + "BnByb3RvMw=="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharSpecialScoutBuyResponse), CharSpecialScoutBuyResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
