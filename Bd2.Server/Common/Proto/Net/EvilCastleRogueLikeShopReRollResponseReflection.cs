using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeShopReRollResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRSZXNwb25zZS9FdmlsQ2FzdGxlUm9ndWVMaWtlU2hvcFJlUm9sbFJlc3Bv" + "bnNlLnByb3RvEglwcm90by5uZXQaK0NvbW1vbnMvRXZpbENhc3RsZVJvZ3Vl" + "TGlrZVNob3BEQkluZm8ucHJvdG8idwolRXZpbENhc3RsZVJvZ3VlTGlrZVNo" + "b3BSZVJvbGxSZXNwb25zZRI7CglzaG9wX2luZm8YASABKAsyKC5wcm90by5u" + "ZXQuRXZpbENhc3RsZVJvZ3VlTGlrZVNob3BEQkluZm8SEQoJdXNlZF9nb2xk" + "GAIgASgFYgZwcm90bzM="), new FileDescriptor[1] { EvilCastleRogueLikeShopDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeShopReRollResponse), EvilCastleRogueLikeShopReRollResponse.Parser, new string[2] { "ShopInfo", "UsedGold" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
