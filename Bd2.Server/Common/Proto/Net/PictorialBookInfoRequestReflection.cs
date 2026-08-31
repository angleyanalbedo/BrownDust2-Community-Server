using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PictorialBookInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L1BpY3RvcmlhbEJvb2tJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjMKGFBpY3RvcmlhbEJvb2tJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSCgoCaWQYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PictorialBookInfoRequest), PictorialBookInfoRequest.Parser, new string[2] { "Seq", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
