using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UseResourceItemResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9Vc2VSZXNvdXJjZUl0ZW1SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRsZS5wcm90byJUChdVc2VSZXNvdXJjZUl0ZW1SZXNwb25zZRI5ChJyZXdhcmRfaW5mb19idW5kbGUYASABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxlYgZwcm90bzM="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UseResourceItemResponse), UseResourceItemResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
