using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackBuyRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSZXF1ZXN0L1BhY2tCdXlSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiLgoOUGFja0J1eVJlcXVlc3QSCwoDc2VxGAEgASgFEg8KB3BhY2tfaWQYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackBuyRequest), PackBuyRequest.Parser, new string[2] { "Seq", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
