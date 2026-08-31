using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostumeBaseDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0Nvc3R1bWVCYXNlREJJbmZvLnByb3RvEglwcm90by5uZXQiLgoRQ29zdHVtZUJhc2VEQkluZm8SCgoCaWQYAiABKAUSDQoFbGV2ZWwYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeBaseDBInfo), CostumeBaseDBInfo.Parser, new string[2] { "Id", "Level" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
