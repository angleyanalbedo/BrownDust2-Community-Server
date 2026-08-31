using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildSupporterAddRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0d1aWxkU3VwcG9ydGVyQWRkUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0InIKGEd1aWxkU3VwcG9ydGVyQWRkUmVxdWVzdBILCgNzZXEYASABKAUSEgoKc2xvdF9pbmRleBgCIAEoBRIYChBjaGFyX2ludmVuX2luZGV4GAMgASgDEhsKE2Nvc3R1bWVfaW52ZW5faW5kZXgYBCABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildSupporterAddRequest), GuildSupporterAddRequest.Parser, new string[4] { "Seq", "SlotIndex", "CharInvenIndex", "CostumeInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
