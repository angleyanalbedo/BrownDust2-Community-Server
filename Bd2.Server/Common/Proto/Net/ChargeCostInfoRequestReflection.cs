using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ChargeCostInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L0NoYXJnZUNvc3RJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjoKFUNoYXJnZUNvc3RJbmZvUmVxdWVzdBILCgNzZXEYASABKAUSFAoMZWxlbWVudF90eXBlGAIgAygFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ChargeCostInfoRequest), ChargeCostInfoRequest.Parser, new string[2] { "Seq", "ElementType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
