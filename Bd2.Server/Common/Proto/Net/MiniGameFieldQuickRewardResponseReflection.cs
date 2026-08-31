using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldQuickRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9SZXNwb25zZS9NaW5pR2FtZUZpZWxkUXVpY2tSZXdhcmRSZXNwb25zZS5w" + "cm90bxIJcHJvdG8ubmV0GiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRsZS5w" + "cm90byJdCiBNaW5pR2FtZUZpZWxkUXVpY2tSZXdhcmRSZXNwb25zZRI5ChJy" + "ZXdhcmRfaW5mb19idW5kbGUYASABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJ" + "bmZvQnVuZGxlYgZwcm90bzM="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldQuickRewardResponse), MiniGameFieldQuickRewardResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
