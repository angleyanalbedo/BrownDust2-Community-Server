using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackEventBattleGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj9jb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L1BhY2tFdmVudEJh" + "dHRsZUdyb3VwVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iXwoZ" + "UGFja0V2ZW50QmF0dGxlR3JvdXBUYWJsZRIYChBiYXR0bGVOYW1lVGV4dElk" + "GAEgASgFEhwKFGV2ZW50TmFtZUxvY2FsVGV4dElkGAIgASgFEgoKAmlkGAMg" + "ASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24u" + "Y29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventBattleGroupTable), PackEventBattleGroupTable.Parser, new string[3] { "BattleNameTextId", "EventNameLocalTextId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
