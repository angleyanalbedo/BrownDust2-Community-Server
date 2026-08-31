using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntDispatchResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9IdW50RGlzcGF0Y2hSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRsZS5wcm90byJRChRIdW50RGlzcGF0Y2hSZXNwb25zZRI5ChJyZXdhcmRfaW5mb19idW5kbGUYASABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxlYgZwcm90bzM="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchResponse), HuntDispatchResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
