using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class RelicDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDb21tb25zL1JlbGljREJJbmZvLnByb3RvEglwcm90by5uZXQiLgoLUmVsaWNEQkluZm8SEwoLaW52ZW5faW5kZXgYASABKAMSCgoCaWQYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RelicDBInfo), RelicDBInfo.Parser, new string[2] { "InvenIndex", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
