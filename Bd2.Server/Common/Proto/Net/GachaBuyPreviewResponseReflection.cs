using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaBuyPreviewResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9HYWNoYUJ1eVByZXZpZXdSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRsZS5wcm90byJTChdHYWNoYUJ1eVByZXZpZXdSZXNwb25zZRI4ChFwcmV2aWV3X2l0ZW1faW5mbxgBIAEoCzIdLnByb3RvLm5ldC5SZXdhcmREQkluZm9CdW5kbGViBnByb3RvMw=="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaBuyPreviewResponse), GachaBuyPreviewResponse.Parser, new string[1] { "PreviewItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
