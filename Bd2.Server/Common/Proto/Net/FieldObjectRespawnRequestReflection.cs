using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectRespawnRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L0ZpZWxkT2JqZWN0UmVzcGF3blJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJzChlGaWVsZE9iamVjdFJlc3Bhd25SZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgASgFEh0KFWZpZWxkX29iamVjdF9ncm91cF9pZBgDIAEoBRIZChFmaWVsZF9vYmplY3RfdHlwZRgEIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectRespawnRequest), FieldObjectRespawnRequest.Parser, new string[4] { "Seq", "PackId", "FieldObjectGroupId", "FieldObjectType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
