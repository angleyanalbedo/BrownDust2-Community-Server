using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleRankUserDetailReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDb21tb25zL1B2cEJhdHRsZVJhbmtVc2VyRGV0YWlsLnByb3RvEglwcm90" + "by5uZXQaI0NvbW1vbnMvUHZwQmF0dGxlVXNlckRlY2tJbmZvLnByb3RvGhhD" + "b21tb25zL0NoYXJEQkluZm8ucHJvdG8aG0NvbW1vbnMvQ29zdHVtZURCSW5m" + "by5wcm90bxoZQ29tbW9ucy9FcXVpcERCSW5mby5wcm90byKVAgoXUHZwQmF0" + "dGxlUmFua1VzZXJEZXRhaWwSCgoCdnAYASABKAUSDAoEcmFuaxgCIAEoBRIR" + "Cgl3aW5fY291bnQYAyABKAUSEgoKbG9zZV9jb3VudBgEIAEoBRIzCglkZWNr" + "X2luZm8YBSADKAsyIC5wcm90by5uZXQuUHZwQmF0dGxlVXNlckRlY2tJbmZv" + "EigKCWNoYXJfaW5mbxgGIAMoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZvEi4K" + "DGNvc3R1bWVfaW5mbxgHIAMoCzIYLnByb3RvLm5ldC5Db3N0dW1lREJJbmZv" + "EioKCmVxdWlwX2luZm8YCCADKAsyFi5wcm90by5uZXQuRXF1aXBEQkluZm9i" + "BnByb3RvMw=="), new FileDescriptor[4]
	{
		PvpBattleUserDeckInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleRankUserDetail), PvpBattleRankUserDetail.Parser, new string[8] { "Vp", "Rank", "WinCount", "LoseCount", "DeckInfo", "CharInfo", "CostumeInfo", "EquipInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
