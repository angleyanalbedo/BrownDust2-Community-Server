using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeScoreInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipDb21tb25zL0V2aWxDYXN0bGVSb2d1ZUxpa2VTY29yZUluZm8ucHJvdG8S" + "CXByb3RvLm5ldBoqQ29tbW9ucy9FdmlsQ2FzdGxlUm9ndWVMaWtlU2NvcmVJ" + "dGVtLnByb3RvItYBChxFdmlsQ2FzdGxlUm9ndWVMaWtlU2NvcmVJbmZvEkAK" + "D3Njb3JlX2l0ZW1faW5mbxgBIAMoCzInLnByb3RvLm5ldC5FdmlsQ2FzdGxl" + "Um9ndWVMaWtlU2NvcmVJdGVtEhMKC3RvdGFsX3Njb3JlGAIgASgFEhAKCG9i" + "c2lkaWFuGAMgASgFEhwKFGFsbF91c2VyX3RvdGFsX3Njb3JlGAQgASgDEhUK" + "DW1heF90cnlfbGV2ZWwYBSABKAUSGAoQbWF4X3Jld2FyZF9sZXZlbBgGIAEo" + "BWIGcHJvdG8z"), new FileDescriptor[1] { EvilCastleRogueLikeScoreItemReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeScoreInfo), EvilCastleRogueLikeScoreInfo.Parser, new string[6] { "ScoreItemInfo", "TotalScore", "Obsidian", "AllUserTotalScore", "MaxTryLevel", "MaxRewardLevel" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
