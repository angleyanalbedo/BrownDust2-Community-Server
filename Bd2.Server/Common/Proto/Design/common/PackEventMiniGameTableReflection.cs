using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackEventMiniGameTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L1BhY2tFdmVudE1p" + "bmlHYW1lVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i5gIKFlBh" + "Y2tFdmVudE1pbmlHYW1lVGFibGUSGQoRZXZlbnRDbGVhclN1YlR5cGUYASAB" + "KAUSFgoOZXZlbnRDbGVhclR5cGUYAiABKAUSFwoPZXZlbnRDbGVhclZhbHVl" + "GAMgASgFEhwKFGV2ZW50RGVzY0xvY2FsVGV4dElkGAQgASgFEhwKFGV2ZW50" + "TmFtZUxvY2FsVGV4dElkGAUgASgFEgoKAmlkGAYgASgFEg0KBW1hcElkGAcg" + "ASgFEh0KFW1pbmlHYW1lUmV3YXJkR3JvdXBJZBgIIAEoBRIOCgZwYWNrSWQY" + "CSABKAUSFwoPcG9pbnRQb3NpdGlvbklkGAogASgFEhIKCnByZWZhYk5hbWUY" + "CyABKAkSFwoPc3RhdGljQ29zdHVtZUlkGAwgASgFEhkKEXN0YXRpY0Nvc3R1" + "bWVQYXRoGA0gASgJEhkKEXN0YXRpY0Nvc3R1bWVUeXBlGA4gASgFQkRCE1By" + "b3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgIT" + "UHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventMiniGameTable), PackEventMiniGameTable.Parser, new string[14]
		{
			"EventClearSubType", "EventClearType", "EventClearValue", "EventDescLocalTextId", "EventNameLocalTextId", "Id", "MapId", "MiniGameRewardGroupId", "PackId", "PointPositionId",
			"PrefabName", "StaticCostumeId", "StaticCostumePath", "StaticCostumeType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
