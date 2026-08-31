using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PictorialBookDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL1BpY3RvcmlhbEJvb2tEQkluZm8ucHJvdG8SCXByb3RvLm5ldCIzChNQaWN0b3JpYWxCb29rREJJbmZvEgoKAmlkGAEgASgFEhAKCGdyb3VwX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PictorialBookDBInfo), PictorialBookDBInfo.Parser, new string[2] { "Id", "GroupId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
