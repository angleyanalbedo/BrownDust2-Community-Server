using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PopularCostumeCountDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL1BvcHVsYXJDb3N0dW1lQ291bnREQkluZm8ucHJvdG8SCXByb3RvLm5ldCJpChlQb3B1bGFyQ29zdHVtZUNvdW50REJJbmZvEgoKAmlkGAEgASgFEhQKDGNvdW50X3R5cGVfMBgCIAEoAxIUCgxjb3VudF90eXBlXzEYAyABKAMSFAoMY291bnRfdHlwZV8yGAQgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PopularCostumeCountDBInfo), PopularCostumeCountDBInfo.Parser, new string[4] { "Id", "CountType0", "CountType1", "CountType2" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
