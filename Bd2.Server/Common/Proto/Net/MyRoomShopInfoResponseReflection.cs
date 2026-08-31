using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomShopInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9NeVJvb21TaG9wSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90" + "by5uZXQiMQoQTXlSb29tU2hvcERCSW5mbxIKCgJpZBgBIAEoBRIRCglidXlf" + "Y291bnQYAiABKAUiTAoWTXlSb29tU2hvcEluZm9SZXNwb25zZRIyCg1zaG9w" + "X2J1eV9pbmZvGAEgAygLMhsucHJvdG8ubmV0Lk15Um9vbVNob3BEQkluZm9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[2]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomShopDBInfo), MyRoomShopDBInfo.Parser, new string[2] { "Id", "BuyCount" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(MyRoomShopInfoResponse), MyRoomShopInfoResponse.Parser, new string[1] { "ShopBuyInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
