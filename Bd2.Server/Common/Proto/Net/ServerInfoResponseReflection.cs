using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ServerInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9TZXJ2ZXJJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5l" + "dCL7AQoSU2VydmVySW5mb1Jlc3BvbnNlEjsKCWluZm9fbGlzdBgBIAMoCzIo" + "LnByb3RvLm5ldC5TZXJ2ZXJJbmZvUmVzcG9uc2UuU2VydmVySW5mbxqnAQoK" + "U2VydmVySW5mbxIOCgZyZWdpb24YASABKBESGAoQZ2FtZV9zZXJ2ZXJfaW5m" + "bxgCIAEoCRIQCghjZG5faW5mbxgDIAEoCRIRCglvcGVuX2ZsYWcYBCABKBES" + "FwoPbG9nX3NlcnZlcl9pbmZvGAUgASgJEhgKEGNoYXJfc2VydmVyX2luZm8Y" + "BiABKAkSFwoPY291cG9uX3dlYl9pbmZvGAcgASgJYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ServerInfoResponse), ServerInfoResponse.Parser, new string[1] { "InfoList" }, null, null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ServerInfoResponse.Types.ServerInfo), ServerInfoResponse.Types.ServerInfo.Parser, new string[7] { "Region", "GameServerInfo", "CdnInfo", "OpenFlag", "LogServerInfo", "CharServerInfo", "CouponWebInfo" }, null, null, null, null)
		})
	}));

	public static FileDescriptor Descriptor => descriptor;
}
