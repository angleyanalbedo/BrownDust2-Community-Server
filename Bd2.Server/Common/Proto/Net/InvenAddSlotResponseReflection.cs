using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class InvenAddSlotResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9JbnZlbkFkZFNsb3RSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0IhYKFEludmVuQWRkU2xvdFJlc3BvbnNlYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(InvenAddSlotResponse), InvenAddSlotResponse.Parser, null, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
