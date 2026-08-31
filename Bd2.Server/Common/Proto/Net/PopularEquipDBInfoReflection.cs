using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PopularEquipDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL1BvcHVsYXJFcXVpcERCSW5mby5wcm90bxIJcHJvdG8ubmV0ImsKElBvcHVsYXJFcXVpcERCSW5mbxIWCg51bmlxdWVfY2hhcl9pZBgBIAEoBRIRCglzbG90X3R5cGUYAiABKAUSFwoPdW5pcXVlX2VxdWlwX2lkGAMgASgFEhEKCXVzZV9jb3VudBgEIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PopularEquipDBInfo), PopularEquipDBInfo.Parser, new string[4] { "UniqueCharId", "SlotType", "UniqueEquipId", "UseCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
