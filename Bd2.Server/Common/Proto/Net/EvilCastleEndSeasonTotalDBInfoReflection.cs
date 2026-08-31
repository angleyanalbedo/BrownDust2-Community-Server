using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleEndSeasonTotalDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixDb21tb25zL0V2aWxDYXN0bGVFbmRTZWFzb25Ub3RhbERCSW5mby5wcm90" + "bxIJcHJvdG8ubmV0GhpDb21tb25zL1Jld2FyZERCSW5mby5wcm90byKAAQoe" + "RXZpbENhc3RsZUVuZFNlYXNvblRvdGFsREJJbmZvEgwKBHJhbmsYASABKAUS" + "DQoFcG9pbnQYAiABKAUSEwoLaXNfcmV3YXJkZWQYAyABKAgSLAoLcmV3YXJk" + "X2luZm8YBCADKAsyFy5wcm90by5uZXQuUmV3YXJkREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { RewardDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleEndSeasonTotalDBInfo), EvilCastleEndSeasonTotalDBInfo.Parser, new string[4] { "Rank", "Point", "IsRewarded", "RewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
