using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ResourceTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL1Jlc291cmNlVGFi" + "bGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ingIKDVJlc291cmNlVGFi" + "bGUSDQoFZ3JhZGUYASABKAUSGgoSaWNvbkJhY2tncm91bmROYW1lGAIgASgJ" + "EhYKDmljb25TcHJpdGVOYW1lGAMgASgJEgoKAmlkGAQgASgFEhUKDWl0ZW1B" + "Y3F1aXJlSWQYBSADKAUSGgoSaXRlbURlc2NOYW1lVGV4dElkGAYgASgFEhYK" + "Dml0ZW1OYW1lVGV4dElkGAcgASgFEhkKEWl0ZW1TdWJOYW1lVGV4dElkGAgg" + "ASgFEhIKCm1hZ2ljVmFsdWUYCSABKAUSEAoIbm90VHJhc2gYCiABKAUSEAoI" + "c29ydFR5cGUYCyABKAUSEgoKc3RhY2tDb3VudBgMIAEoBRIMCgR0eXBlGA0g" + "ASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24u" + "Y29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ResourceTable), ResourceTable.Parser, new string[13]
		{
			"Grade", "IconBackgroundName", "IconSpriteName", "Id", "ItemAcquireId", "ItemDescNameTextId", "ItemNameTextId", "ItemSubNameTextId", "MagicValue", "NotTrash",
			"SortType", "StackCount", "Type"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
