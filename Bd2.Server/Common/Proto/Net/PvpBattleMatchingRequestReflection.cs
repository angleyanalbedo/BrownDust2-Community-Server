using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleMatchingRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L1B2cEJhdHRsZU1hdGNoaW5nUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkEKGFB2cEJhdHRsZU1hdGNoaW5nUmVxdWVzdBILCgNzZXEYASABKAUSGAoQYm9vc3RfcHZwX3RpY2tldBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleMatchingRequest), PvpBattleMatchingRequest.Parser, new string[2] { "Seq", "BoostPvpTicket" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
