using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipBreakResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9FcXVpcEJyZWFrUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBogQ29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8iTwoSRXF1aXBCcmVha1Jlc3BvbnNlEjkKEnJld2FyZF9pbmZvX2J1bmRsZRgBIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQkluZm9CdW5kbGViBnByb3RvMw=="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipBreakResponse), EquipBreakResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
