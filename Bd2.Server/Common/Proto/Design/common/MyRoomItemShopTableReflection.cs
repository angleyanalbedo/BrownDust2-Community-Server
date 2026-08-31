using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MyRoomItemShopTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvTXlSb29tX19f66eI7J2066O4L015Um9vbUl0ZW1TaG9w" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24irAEKE015Um9vbUl0" + "ZW1TaG9wVGFibGUSEwoLYnV5TWF4Q291bnQYASABKAUSFAoMZWxlbWVudENv" + "dW50GAIgASgFEhEKCWVsZW1lbnRJZBgDIAEoBRITCgtlbGVtZW50VHlwZRgE" + "IAEoBRIKCgJpZBgFIAEoBRISCgpwcmljZUNvdW50GAYgASgFEg8KB3ByaWNl" + "SWQYByABKAUSEQoJcHJpY2VUeXBlGAggASgFQkRCE1Byb3RvLkRlc2lnbi5j" + "b21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWdu" + "LmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomItemShopTable), MyRoomItemShopTable.Parser, new string[8] { "BuyMaxCount", "ElementCount", "ElementId", "ElementType", "Id", "PriceCount", "PriceId", "PriceType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
