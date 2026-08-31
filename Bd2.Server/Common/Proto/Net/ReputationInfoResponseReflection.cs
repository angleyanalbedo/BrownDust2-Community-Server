using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ReputationInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9SZXB1dGF0aW9uSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaHkNvbW1vbnMvUmVwdXRhdGlvbkRCSW5mby5wcm90byJOChZSZXB1dGF0aW9uSW5mb1Jlc3BvbnNlEjQKD3JlcHV0YXRpb25faW5mbxgBIAMoCzIbLnByb3RvLm5ldC5SZXB1dGF0aW9uREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { ReputationDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ReputationInfoResponse), ReputationInfoResponse.Parser, new string[1] { "ReputationInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
