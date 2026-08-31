using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeQuickBattleRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNSZXF1ZXN0L0V2aWxDYXN0bGVSb2d1ZUxpa2VRdWlja0JhdHRsZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJYCiVFdmlsQ2FzdGxlUm9ndWVMaWtlUXVpY2tCYXR0bGVSZXF1ZXN0EgsKA3NlcRgBIAEoBRINCgVsZXZlbBgCIAEoBRITCgtjbGVhcl9jb3VudBgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeQuickBattleRequest), EvilCastleRogueLikeQuickBattleRequest.Parser, new string[3] { "Seq", "Level", "ClearCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
