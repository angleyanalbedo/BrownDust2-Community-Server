using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleRankingRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L1B2cEJhdHRsZVJhbmtpbmdSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiNgoXUHZwQmF0dGxlUmFua2luZ1JlcXVlc3QSCwoDc2VxGAEgASgFEg4KBnNlYXNvbhgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleRankingRequest), PvpBattleRankingRequest.Parser, new string[2] { "Seq", "Season" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
