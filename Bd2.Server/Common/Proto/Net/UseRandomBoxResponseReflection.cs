using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UseRandomBoxResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9Vc2VSYW5kb21Cb3hSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRsZS5wcm90byJRChRVc2VSYW5kb21Cb3hSZXNwb25zZRI5ChJyZXdhcmRfaW5mb19idW5kbGUYASABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxlYgZwcm90bzM="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UseRandomBoxResponse), UseRandomBoxResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
