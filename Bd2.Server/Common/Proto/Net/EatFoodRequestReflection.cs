using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EatFoodRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSZXF1ZXN0L0VhdEZvb2RSZXF1ZXN0LnByb3RvEglwcm90by5uZXQaGENv" + "bW1vbnMvSXRlbURCSW5mby5wcm90byJtCg5FYXRGb29kUmVxdWVzdBILCgNz" + "ZXEYASABKAUSDwoHcGFja19pZBgCIAEoBRITCgtpbnZlbl9pbmRleBgDIAEo" + "AxIoCglpdGVtX2luZm8YBCADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IG" + "cHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EatFoodRequest), EatFoodRequest.Parser, new string[4] { "Seq", "PackId", "InvenIndex", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
