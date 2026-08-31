using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class LoginUserResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9Mb2dpblVzZXJSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0" + "GhhDb21tb25zL1VzZXJEQkluZm8ucHJvdG8aIENvbW1vbnMvUmV3YXJkREJJ" + "bmZvQnVuZGxlLnByb3RvGhpDb21tb25zL1Jld2FyZERCSW5mby5wcm90bxof" + "Q29tbW9ucy9HdWlsZE1lbWJlckRCSW5mby5wcm90bxodQ29tbW9ucy9HdWls" + "ZEJhc2VEQkluZm8ucHJvdG8i1AIKEUxvZ2luVXNlclJlc3BvbnNlEigKCXVz" + "ZXJfaW5mbxgBIAEoCzIVLnByb3RvLm5ldC5Vc2VyREJJbmZvEiIKGmFjY3Vt" + "dWxhdGVkX3BheW1lbnRfYW1vdW50GAIgASgCEhUKDWRhdGVfb2ZfYmlydGgY" + "AyABKAUSOQoScmV3YXJkX2luZm9fYnVuZGxlGAQgASgLMh0ucHJvdG8ubmV0" + "LlJld2FyZERCSW5mb0J1bmRsZRIzChJyZXBheW1lbnRfY3VycmVuY3kYBSAD" + "KAsyFy5wcm90by5uZXQuUmV3YXJkREJJbmZvEjUKD3VzZXJfZ3VpbGRfaW5m" + "bxgGIAEoCzIcLnByb3RvLm5ldC5HdWlsZE1lbWJlckRCSW5mbxIzCg9ndWls" + "ZF9iYXNlX2luZm8YByABKAsyGi5wcm90by5uZXQuR3VpbGRCYXNlREJJbmZv" + "YgZwcm90bzM="), new FileDescriptor[5]
	{
		UserDBInfoReflection.Descriptor,
		RewardDBInfoBundleReflection.Descriptor,
		RewardDBInfoReflection.Descriptor,
		GuildMemberDBInfoReflection.Descriptor,
		GuildBaseDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LoginUserResponse), LoginUserResponse.Parser, new string[7] { "UserInfo", "AccumulatedPaymentAmount", "DateOfBirth", "RewardInfoBundle", "RepaymentCurrency", "UserGuildInfo", "GuildBaseInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
