using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleResetRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L1B2cEJhdHRsZVJlc2V0UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjcKFVB2cEJhdHRsZVJlc2V0UmVxdWVzdBILCgNzZXEYASABKAUSEQoJZGVja190eXBlGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleResetRequest), PvpBattleResetRequest.Parser, new string[2] { "Seq", "DeckType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
