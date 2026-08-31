using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntQuickBattleRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitSZXF1ZXN0L01vbnN0ZXJIdW50UXVpY2tCYXR0bGVSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiLAodTW9uc3Rlckh1bnRRdWlja0JhdHRsZVJlcXVlc3QSCwoDc2VxGAEgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntQuickBattleRequest), MonsterHuntQuickBattleRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
