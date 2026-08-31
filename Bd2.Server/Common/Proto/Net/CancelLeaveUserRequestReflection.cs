using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CancelLeaveUserRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0NhbmNlbExlYXZlVXNlclJlcXVlc3QucHJvdG8SCXByb3RvLm5ldBoVQ29tbW9ucy9FbnZJbmZvLnByb3RvImEKFkNhbmNlbExlYXZlVXNlclJlcXVlc3QSCwoDc2VxGAEgASgFEhQKDGFjY2Vzc190b2tlbhgCIAEoCRIkCghlbnZfaW5mbxgDIAEoCzISLnByb3RvLm5ldC5FbnZJbmZvYgZwcm90bzM="), new FileDescriptor[1] { EnvInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CancelLeaveUserRequest), CancelLeaveUserRequest.Parser, new string[3] { "Seq", "AccessToken", "EnvInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
