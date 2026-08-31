using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldMonsterEventRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0ZpZWxkTW9uc3RlckV2ZW50UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkwKGEZpZWxkTW9uc3RlckV2ZW50UmVxdWVzdBILCgNzZXEYASABKAUSEgoKbW9uc3Rlcl9pZBgCIAEoBRIPCgdpc19kYXNoGAMgASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMonsterEventRequest), FieldMonsterEventRequest.Parser, new string[3] { "Seq", "MonsterId", "IsDash" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
