using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class StatueObjectRewardResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9TdGF0dWVPYmplY3RSZXdhcmRSZXNwb25zZS5wcm90bxIJ" + "cHJvdG8ubmV0GiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRsZS5wcm90byJX" + "ChpTdGF0dWVPYmplY3RSZXdhcmRSZXNwb25zZRI5ChJyZXdhcmRfaW5mb19i" + "dW5kbGUYASABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxlYgZw" + "cm90bzM="), new FileDescriptor[1] { RewardDBInfoBundleReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(StatueObjectRewardResponse), StatueObjectRewardResponse.Parser, new string[1] { "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
