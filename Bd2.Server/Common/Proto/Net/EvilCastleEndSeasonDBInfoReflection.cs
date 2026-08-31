using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleEndSeasonDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidDb21tb25zL0V2aWxDYXN0bGVFbmRTZWFzb25EQkluZm8ucHJvdG8SCXBy" + "b3RvLm5ldBoaQ29tbW9ucy9SZXdhcmREQkluZm8ucHJvdG8ikAEKGUV2aWxD" + "YXN0bGVFbmRTZWFzb25EQkluZm8SDAoEcmFuaxgBIAEoBRITCgtzdGFnZV9p" + "bmRleBgCIAEoBRINCgVwb2ludBgDIAEoBRITCgtpc19yZXdhcmRlZBgEIAEo" + "CBIsCgtyZXdhcmRfaW5mbxgFIAMoCzIXLnByb3RvLm5ldC5SZXdhcmREQklu" + "Zm9iBnByb3RvMw=="), new FileDescriptor[1] { RewardDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleEndSeasonDBInfo), EvilCastleEndSeasonDBInfo.Parser, new string[5] { "Rank", "StageIndex", "Point", "IsRewarded", "RewardInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
