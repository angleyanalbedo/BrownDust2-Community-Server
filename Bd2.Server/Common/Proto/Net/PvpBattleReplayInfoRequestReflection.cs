using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleReplayInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L1B2cEJhdHRsZVJlcGxheUluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiRQoaUHZwQmF0dGxlUmVwbGF5SW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFEhoKEmJhdHRsZV9pbnZlbl9pbmRleBgCIAEoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleReplayInfoRequest), PvpBattleReplayInfoRequest.Parser, new string[2] { "Seq", "BattleInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
