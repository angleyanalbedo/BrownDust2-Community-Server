using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharScoutInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXNwb25zZS9DaGFyU2NvdXRJbmZvUmVzcG9uc2UucHJvdG8SCXByb3Rv" + "Lm5ldCKGAQoVQ2hhclNjb3V0SW5mb1Jlc3BvbnNlEhYKDmFwcGVhcl9jaGFy" + "X2lkGAEgAygFEhcKD3VzZV9yZXNldF9jb3VudBgCIAEoBRIcChRuZXh0X2F1" + "dG9fcmVzZXRfdGltZRgDIAEoAxIeChZzY291dF9jb21wbGV0ZV9jaGFyX2lk" + "GAQgAygFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharScoutInfoResponse), CharScoutInfoResponse.Parser, new string[4] { "AppearCharId", "UseResetCount", "NextAutoResetTime", "ScoutCompleteCharId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
