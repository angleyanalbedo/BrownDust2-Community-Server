using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MercenaryScoutRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L01lcmNlbmFyeVNjb3V0UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8iXgoVTWVyY2VuYXJ5U2NvdXRSZXF1ZXN0EgsKA3NlcRgBIAEoBRIOCgZucGNfaWQYAiABKAUSKAoJaXRlbV9pbmZvGAMgAygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MercenaryScoutRequest), MercenaryScoutRequest.Parser, new string[3] { "Seq", "NpcId", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
