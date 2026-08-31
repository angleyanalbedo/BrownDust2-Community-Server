using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CookingResearchRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0Nvb2tpbmdSZXNlYXJjaFJlcXVlc3QucHJvdG8SCXByb3Rv" + "Lm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvIncKFkNvb2tpbmdSZXNl" + "YXJjaFJlcXVlc3QSCwoDc2VxGAEgASgFEhMKC2ludmVuX2luZGV4GAIgASgD" + "EhEKCXJlY2lwZV9pZBgDIAEoBRIoCglpdGVtX2luZm8YBCADKAsyFS5wcm90" + "by5uZXQuSXRlbURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CookingResearchRequest), CookingResearchRequest.Parser, new string[4] { "Seq", "InvenIndex", "RecipeId", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
