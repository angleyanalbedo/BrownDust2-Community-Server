using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostTimeDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDb21tb25zL0Nvc3RUaW1lREJJbmZvLnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvSXRlbURCSW5mby5wcm90byJZCg5Db3N0VGltZURCSW5mbxIYChBsYXN0X2NoYXJnZV90aW1lGAEgASgDEi0KDmNvc3RfaXRlbV9pbmZvGAIgASgLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostTimeDBInfo), CostTimeDBInfo.Parser, new string[2] { "LastChargeTime", "CostItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
