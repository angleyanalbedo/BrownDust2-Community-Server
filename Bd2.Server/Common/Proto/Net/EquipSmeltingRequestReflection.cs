using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipSmeltingRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L0VxdWlwU21lbHRpbmdSZXF1ZXN0LnByb3RvEglwcm90by5u" + "ZXQaGENvbW1vbnMvSXRlbURCSW5mby5wcm90byJiChRFcXVpcFNtZWx0aW5n" + "UmVxdWVzdBILCgNzZXEYASABKAUSEwoLaW52ZW5faW5kZXgYAiABKAMSKAoJ" + "aXRlbV9pbmZvGAMgAygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipSmeltingRequest), EquipSmeltingRequest.Parser, new string[3] { "Seq", "InvenIndex", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
