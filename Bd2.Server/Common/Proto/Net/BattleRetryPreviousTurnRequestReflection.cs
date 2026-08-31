using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleRetryPreviousTurnRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXF1ZXN0L0JhdHRsZVJldHJ5UHJldmlvdXNUdXJuUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkMKHkJhdHRsZVJldHJ5UHJldmlvdXNUdXJuUmVxdWVzdBILCgNzZXEYASABKAUSFAoMYmF0dGxlX2luZGV4GAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleRetryPreviousTurnRequest), BattleRetryPreviousTurnRequest.Parser, new string[2] { "Seq", "BattleIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
