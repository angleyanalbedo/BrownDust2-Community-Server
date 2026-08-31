using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ItemStoragePutResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9JdGVtU3RvcmFnZVB1dFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvSXRlbURCSW5mby5wcm90byJCChZJdGVtU3RvcmFnZVB1dFJlc3BvbnNlEigKCWl0ZW1faW5mbxgBIAMoCzIVLnByb3RvLm5ldC5JdGVtREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ItemStoragePutResponse), ItemStoragePutResponse.Parser, new string[1] { "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
