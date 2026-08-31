using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ReputationDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Db21tb25zL1JlcHV0YXRpb25EQkluZm8ucHJvdG8SCXByb3RvLm5ldCJMChBSZXB1dGF0aW9uREJJbmZvEhAKCGdyb3VwX2lkGAEgASgFEg0KBXN0YXRlGAIgASgFEhcKD2VsYXBzZWRfc2Vjb25kcxgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ReputationDBInfo), ReputationDBInfo.Parser, new string[3] { "GroupId", "State", "ElapsedSeconds" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
