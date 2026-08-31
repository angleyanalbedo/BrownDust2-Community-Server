using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class QuickBattleRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L1F1aWNrQmF0dGxlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "IpgBChJRdWlja0JhdHRsZVJlcXVlc3QSCwoDc2VxGAEgASgFEhMKC2JhdHRs" + "ZV9tb2RlGAIgASgFEhQKDGJhdHRsZV9pbmRleBgDIAEoBRIcChRzdGFnZV9t" + "YWdpY19ncm91cF9pZBgEIAEoBRIWCg5zdGFnZV9tYWdpY19pZBgFIAEoBRIU" + "CgxiYXR0bGVfY291bnQYBiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(QuickBattleRequest), QuickBattleRequest.Parser, new string[6] { "Seq", "BattleMode", "BattleIndex", "StageMagicGroupId", "StageMagicId", "BattleCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
