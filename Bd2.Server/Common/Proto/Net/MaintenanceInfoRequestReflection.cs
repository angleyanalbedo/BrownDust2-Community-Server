using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MaintenanceInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L01haW50ZW5hbmNlSW5mb1JlcXVlc3QucHJvdG8SCXByb3Rv" + "Lm5ldCKQAQoWTWFpbnRlbmFuY2VJbmZvUmVxdWVzdBILCgNzZXEYASABKAUS" + "EwoLbWFya2V0X3R5cGUYAiABKBESDwoHdmVyc2lvbhgDIAEoCRIWCg5idW5k" + "bGVfdmVyc2lvbhgEIAEoCRIUCgxhY2Nlc3NfdG9rZW4YBSABKAkSFQoNbGFu" + "Z3VhZ2VfdHlwZRgGIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MaintenanceInfoRequest), MaintenanceInfoRequest.Parser, new string[6] { "Seq", "MarketType", "Version", "BundleVersion", "AccessToken", "LanguageType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
