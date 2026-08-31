using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AlchemyRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSZXF1ZXN0L0FsY2hlbXlSZXF1ZXN0LnByb3RvEglwcm90by5uZXQaGENv" + "bW1vbnMvSXRlbURCSW5mby5wcm90byKHAQoOQWxjaGVteVJlcXVlc3QSCwoD" + "c2VxGAEgASgFEhMKC2ludmVuX2luZGV4GAIgASgDEhIKCmFsY2hlbXlfaWQY" + "AyABKAUSFQoNYWxjaGVteV9jb3VudBgEIAEoBRIoCglpdGVtX2luZm8YBSAD" + "KAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AlchemyRequest), AlchemyRequest.Parser, new string[5] { "Seq", "InvenIndex", "AlchemyId", "AlchemyCount", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
