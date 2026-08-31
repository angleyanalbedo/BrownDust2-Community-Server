using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleRetryRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0JhdHRsZVJldHJ5UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjcKEkJhdHRsZVJldHJ5UmVxdWVzdBILCgNzZXEYASABKAUSFAoMYmF0dGxlX2luZGV4GAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleRetryRequest), BattleRetryRequest.Parser, new string[2] { "Seq", "BattleIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
