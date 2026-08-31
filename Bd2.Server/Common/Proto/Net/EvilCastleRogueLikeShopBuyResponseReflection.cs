using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeShopBuyResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjFSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlU2hvcEJ1eVJlc3BvbnNl" + "LnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvQ2hhckRCSW5mby5wcm90bxob" + "Q29tbW9ucy9Db3N0dW1lREJJbmZvLnByb3RvGhlDb21tb25zL1JlbGljREJJ" + "bmZvLnByb3RvIr0BCiJFdmlsQ2FzdGxlUm9ndWVMaWtlU2hvcEJ1eVJlc3Bv" + "bnNlEigKCWNoYXJfaW5mbxgBIAMoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZv" + "Ei4KDGNvc3R1bWVfaW5mbxgCIAEoCzIYLnByb3RvLm5ldC5Db3N0dW1lREJJ" + "bmZvEioKCnJlbGljX2luZm8YAyABKAsyFi5wcm90by5uZXQuUmVsaWNEQklu" + "Zm8SEQoJdXNlZF9nb2xkGAQgASgFYgZwcm90bzM="), new FileDescriptor[3]
	{
		CharDBInfoReflection.Descriptor,
		CostumeDBInfoReflection.Descriptor,
		RelicDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeShopBuyResponse), EvilCastleRogueLikeShopBuyResponse.Parser, new string[4] { "CharInfo", "CostumeInfo", "RelicInfo", "UsedGold" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
