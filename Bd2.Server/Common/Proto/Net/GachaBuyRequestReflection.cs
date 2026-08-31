using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaBuyRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SZXF1ZXN0L0dhY2hhQnV5UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0GhhD" + "b21tb25zL0l0ZW1EQkluZm8ucHJvdG8ijQEKD0dhY2hhQnV5UmVxdWVzdBIL" + "CgNzZXEYASABKAUSCgoCaWQYAiABKAUSEAoIYnV5X3R5cGUYAyABKAUSNAoV" + "dXNlX2dhY2hhX3RpY2tldF9pbmZvGAQgAygLMhUucHJvdG8ubmV0Lkl0ZW1E" + "QkluZm8SGQoRY2hhcl9lbGVtZW50X3R5cGUYBSABKAViBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaBuyRequest), GachaBuyRequest.Parser, new string[5] { "Seq", "Id", "BuyType", "UseGachaTicketInfo", "CharElementType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
