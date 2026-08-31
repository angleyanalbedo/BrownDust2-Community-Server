using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharSpecialScoutBuyRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L0NoYXJTcGVjaWFsU2NvdXRCdXlSZXF1ZXN0LnByb3RvEglw" + "cm90by5uZXQaGENvbW1vbnMvSXRlbURCSW5mby5wcm90byJfChpDaGFyU3Bl" + "Y2lhbFNjb3V0QnV5UmVxdWVzdBILCgNzZXEYASABKAUSCgoCaWQYAiABKAUS" + "KAoJaXRlbV9pbmZvGAMgAygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharSpecialScoutBuyRequest), CharSpecialScoutBuyRequest.Parser, new string[3] { "Seq", "Id", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
