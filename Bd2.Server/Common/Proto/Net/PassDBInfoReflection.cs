using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PassDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb21tb25zL1Bhc3NEQkluZm8ucHJvdG8SCXByb3RvLm5ldCI/CgpQYXNzREJJbmZvEgoKAmlkGAEgASgFEgsKA2V4cBgCIAEoBRIYChBhY3RpdmVfcHJlbWl1bV8xGAMgASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PassDBInfo), PassDBInfo.Parser, new string[3] { "Id", "Exp", "ActivePremium1" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
