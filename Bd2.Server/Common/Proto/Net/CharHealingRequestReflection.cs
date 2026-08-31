using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharHealingRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0NoYXJIZWFsaW5nUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0Il4KEkNoYXJIZWFsaW5nUmVxdWVzdBILCgNzZXEYASABKAUSEwoLaW52ZW5faW5kZXgYAiABKAMSEgoKY2hhcl9pbnZlbhgDIAMoAxISCgpmb29kX2luZGV4GAQgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharHealingRequest), CharHealingRequest.Parser, new string[4] { "Seq", "InvenIndex", "CharInven", "FoodIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
