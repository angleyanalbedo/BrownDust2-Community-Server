using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CommunityRewardInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9Db21tdW5pdHlSZXdhcmRJbmZvUmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldCI3ChVDb21tdW5pdHlSZXdhcmREQkluZm8SDAoEdHlwZRgB" + "IAEoBRIQCghzdWJfdHlwZRgCIAEoBSJeChtDb21tdW5pdHlSZXdhcmRJbmZv" + "UmVzcG9uc2USPwoVY29tbXVuaXR5X3Jld2FyZF9pbmZvGAEgAygLMiAucHJv" + "dG8ubmV0LkNvbW11bml0eVJld2FyZERCSW5mb2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(CommunityRewardDBInfo), CommunityRewardDBInfo.Parser, new string[2] { "Type", "SubType" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(CommunityRewardInfoResponse), CommunityRewardInfoResponse.Parser, new string[1] { "CommunityRewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
