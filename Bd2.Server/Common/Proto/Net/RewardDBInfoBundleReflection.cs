using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class RewardDBInfoBundleReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL1Jld2FyZERCSW5mb0J1bmRsZS5wcm90bxIJcHJvdG8ubmV0" + "GhhDb21tb25zL0l0ZW1EQkluZm8ucHJvdG8aGENvbW1vbnMvQ2hhckRCSW5m" + "by5wcm90bxoZQ29tbW9ucy9FcXVpcERCSW5mby5wcm90bxobQ29tbW9ucy9D" + "b3N0dW1lREJJbmZvLnByb3RvGiBDb21tb25zL015Um9vbVRyb3BoeURCSW5m" + "by5wcm90bxoiQ29tbW9ucy9JdGVtQXV0b0V4Y2hhbmdlSW5mby5wcm90bxoh" + "Q29tbW9ucy9JdGVtQXV0b1VwZ3JhZGVJbmZvLnByb3RvGhpDb21tb25zL1Jl" + "d2FyZERCSW5mby5wcm90byKWBAoSUmV3YXJkREJJbmZvQnVuZGxlEigKCWl0" + "ZW1faW5mbxgBIAMoCzIVLnByb3RvLm5ldC5JdGVtREJJbmZvEigKCWNoYXJf" + "aW5mbxgCIAMoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZvEi4KDGNvc3R1bWVf" + "aW5mbxgDIAMoCzIYLnByb3RvLm5ldC5Db3N0dW1lREJJbmZvEioKCmVxdWlw" + "X2luZm8YBCADKAsyFi5wcm90by5uZXQuRXF1aXBEQkluZm8SOgoTbXlfcm9v" + "bV90cm9waHlfaW5mbxgFIAMoCzIdLnByb3RvLm5ldC5NeVJvb21Ucm9waHlE" + "QkluZm8SLQoOdmlld19pdGVtX2luZm8YBiADKAsyFS5wcm90by5uZXQuSXRl" + "bURCSW5mbxIxChJvcmlnaW5hbF9pdGVtX2luZm8YByADKAsyFS5wcm90by5u" + "ZXQuSXRlbURCSW5mbxJAChdpdGVtX2F1dG9fZXhjaGFuZ2VfaW5mbxgIIAMo" + "CzIfLnByb3RvLm5ldC5JdGVtQXV0b0V4Y2hhbmdlSW5mbxI+ChZpdGVtX2F1" + "dG9fdXBncmFkZV9pbmZvGAkgAygLMh4ucHJvdG8ubmV0Lkl0ZW1BdXRvVXBn" + "cmFkZUluZm8SMAoPcmVwYWlkX2N1cnJlbmN5GAogAygLMhcucHJvdG8ubmV0" + "LlJld2FyZERCSW5mb2IGcHJvdG8z"), new FileDescriptor[8]
	{
		ItemDBInfoReflection.Descriptor,
		CharDBInfoReflection.Descriptor,
		EquipDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		MyRoomTrophyDBInfoReflection.Descriptor,
		ItemAutoExchangeInfoReflection.Descriptor,
		ItemAutoUpgradeInfoReflection.Descriptor,
		RewardDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RewardDBInfoBundle), RewardDBInfoBundle.Parser, new string[10] { "ItemInfo", "CharInfo", "CostumeInfo", "EquipInfo", "MyRoomTrophyInfo", "ViewItemInfo", "OriginalItemInfo", "ItemAutoExchangeInfo", "ItemAutoUpgradeInfo", "RepaidCurrency" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
