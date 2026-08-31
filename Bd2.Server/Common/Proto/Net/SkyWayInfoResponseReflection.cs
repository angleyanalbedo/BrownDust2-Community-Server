using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SkyWayInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNwb25zZS9Ta3lXYXlJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoaQ29tbW9ucy9Ta3lXYXlEQkluZm8ucHJvdG8iQwoSU2t5V2F5SW5mb1Jlc3BvbnNlEi0KDHNreV93YXlfaW5mbxgBIAMoCzIXLnByb3RvLm5ldC5Ta3lXYXlEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { SkyWayDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkyWayInfoResponse), SkyWayInfoResponse.Parser, new string[1] { "SkyWayInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
