using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0ZpZWxkT2JqZWN0SW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI2ChZGaWVsZE9iamVjdEluZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgdwYWNrX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectInfoRequest), FieldObjectInfoRequest.Parser, new string[2] { "Seq", "PackId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
