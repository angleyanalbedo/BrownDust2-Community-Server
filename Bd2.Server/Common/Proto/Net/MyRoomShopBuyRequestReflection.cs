using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomShopBuyRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L015Um9vbVNob3BCdXlSZXF1ZXN0LnByb3RvEglwcm90by5u" + "ZXQaGENvbW1vbnMvSXRlbURCSW5mby5wcm90byJxChRNeVJvb21TaG9wQnV5" + "UmVxdWVzdBILCgNzZXEYASABKAUSCgoCaWQYAiABKAUSEgoKaXRlbV9jb3Vu" + "dBgDIAEoBRIsCg11c2VfaXRlbV9pbmZvGAQgAygLMhUucHJvdG8ubmV0Lkl0" + "ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomShopBuyRequest), MyRoomShopBuyRequest.Parser, new string[4] { "Seq", "Id", "ItemCount", "UseItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
