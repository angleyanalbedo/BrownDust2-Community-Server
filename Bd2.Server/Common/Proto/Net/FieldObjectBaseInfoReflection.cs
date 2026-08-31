using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectBaseInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL0ZpZWxkT2JqZWN0QmFzZUluZm8ucHJvdG8SCXByb3RvLm5ldCIzChNGaWVsZE9iamVjdEJhc2VJbmZvEhAKCGdyb3VwX2lkGAMgASgFEgoKAmlkGAQgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectBaseInfo), FieldObjectBaseInfo.Parser, new string[2] { "GroupId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
