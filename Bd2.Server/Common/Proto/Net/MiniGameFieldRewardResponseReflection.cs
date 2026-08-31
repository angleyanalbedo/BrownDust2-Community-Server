using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9NaW5pR2FtZUZpZWxkUmV3YXJkUmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvIl8KG01pbmlH" + "YW1lRmllbGRSZXdhcmRSZXNwb25zZRIZChFsYXN0X3Jld2FyZF9wb2ludBgB" + "IAEoBRIlCgZyZXdhcmQYAiADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IG" + "cHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldRewardResponse), MiniGameFieldRewardResponse.Parser, new string[2] { "LastRewardPoint", "Reward" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
