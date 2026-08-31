using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PlatformLoginResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9QbGF0Zm9ybUxvZ2luUmVzcG9uc2UucHJvdG8SCXByb3Rv" + "Lm5ldBoYQ29tbW9ucy9Vc2VyREJJbmZvLnByb3RvGh9Db21tb25zL0d1aWxk" + "TWVtYmVyREJJbmZvLnByb3RvGh1Db21tb25zL0d1aWxkQmFzZURCSW5mby5w" + "cm90byKtAQoVUGxhdGZvcm1Mb2dpblJlc3BvbnNlEigKCXVzZXJfaW5mbxgB" + "IAEoCzIVLnByb3RvLm5ldC5Vc2VyREJJbmZvEjUKD3VzZXJfZ3VpbGRfaW5m" + "bxgCIAEoCzIcLnByb3RvLm5ldC5HdWlsZE1lbWJlckRCSW5mbxIzCg9ndWls" + "ZF9iYXNlX2luZm8YAyABKAsyGi5wcm90by5uZXQuR3VpbGRCYXNlREJJbmZv" + "YgZwcm90bzM="), new FileDescriptor[3]
	{
		UserDBInfoReflection.Descriptor,
		GuildMemberDBInfoReflection.Descriptor,
		GuildBaseDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PlatformLoginResponse), PlatformLoginResponse.Parser, new string[3] { "UserInfo", "UserGuildInfo", "GuildBaseInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
