using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectRespawnDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZDb21tb25zL0ZpZWxkT2JqZWN0UmVzcGF3bkRCSW5mby5wcm90bxIJcHJvdG8ubmV0Ik8KGEZpZWxkT2JqZWN0UmVzcGF3bkRCSW5mbxIdChVmaWVsZF9vYmplY3RfZ3JvdXBfaWQYASABKAUSFAoMcmVzcGF3bl90aW1lGAIgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectRespawnDBInfo), FieldObjectRespawnDBInfo.Parser, new string[2] { "FieldObjectGroupId", "RespawnTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
