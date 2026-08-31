using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeEditEventRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjFSZXF1ZXN0L0V2aWxDYXN0bGVSb2d1ZUxpa2VFZGl0RXZlbnRSZXF1ZXN0LnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvRGVja0RCSW5mby5wcm90byJQCiNFdmlsQ2FzdGxlUm9ndWVMaWtlRWRpdEV2ZW50UmVxdWVzdBILCgNzZXEYASABKAUSEAoIZ3JvdXBfaWQYAiABKAUSCgoCaWQYAyABKAViBnByb3RvMw=="), new FileDescriptor[1] { DeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeEditEventRequest), EvilCastleRogueLikeEditEventRequest.Parser, new string[3] { "Seq", "GroupId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
