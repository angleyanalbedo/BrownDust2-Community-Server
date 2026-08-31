using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ShopInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9TaG9wSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvU2hvcERCSW5mby5wcm90byI8ChBTaG9wSW5mb1Jlc3BvbnNlEigKCXNob3BfaW5mbxgBIAEoCzIVLnByb3RvLm5ldC5TaG9wREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { ShopDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShopInfoResponse), ShopInfoResponse.Parser, new string[1] { "ShopInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
