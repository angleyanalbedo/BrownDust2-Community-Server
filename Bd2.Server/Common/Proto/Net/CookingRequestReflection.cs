using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CookingRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSZXF1ZXN0L0Nvb2tpbmdSZXF1ZXN0LnByb3RvEglwcm90by5uZXQaGENv" + "bW1vbnMvSXRlbURCSW5mby5wcm90byKGAQoOQ29va2luZ1JlcXVlc3QSCwoD" + "c2VxGAEgASgFEhMKC2ludmVuX2luZGV4GAIgASgDEhEKCXJlY2lwZV9pZBgD" + "IAEoBRIVCg1jb29raW5nX2NvdW50GAQgASgFEigKCWl0ZW1faW5mbxgFIAMo" + "CzIVLnByb3RvLm5ldC5JdGVtREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CookingRequest), CookingRequest.Parser, new string[5] { "Seq", "InvenIndex", "RecipeId", "CookingCount", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
