using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ItemStorageUpdateResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9JdGVtU3RvcmFnZVVwZGF0ZVJlc3BvbnNlLnByb3RvEglwcm90by5uZXQiGwoZSXRlbVN0b3JhZ2VVcGRhdGVSZXNwb25zZWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ItemStorageUpdateResponse), ItemStorageUpdateResponse.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
