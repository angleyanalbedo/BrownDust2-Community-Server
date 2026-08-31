using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLLevelTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STExldmVs" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ilwIKDFJMTGV2ZWxU" + "YWJsZRIXCg9jaGFyQXBwbHlCdWZmSWQYASABKAUSFwoPZW5lbXlEYW1hZ2VS" + "YXRlGAIgASgBEhcKD2VuZW15SGVhbHRoUmF0ZRgDIAEoARITCgtnZXRHb2xk" + "UmF0ZRgEIAEoARIKCgJpZBgFIAEoBRITCgtyZXdhcmRDb3VudBgGIAMoBRIQ" + "CghyZXdhcmRJZBgHIAMoBRISCgpyZXdhcmRUeXBlGAggAygFEhYKDnNjb3Jl" + "Qm9udXNSYXRlGAkgASgBEhoKEnNob3BEaXNjb3VudENoYW5jZRgKIAEoARIU" + "CgxzcFN0YXJ0Q291bnQYCyABKAUSFgoOc3BUdXJuQWRkQ291bnQYDCABKAVC" + "REITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21t" + "b26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLLevelTable), RLLevelTable.Parser, new string[12]
		{
			"CharApplyBuffId", "EnemyDamageRate", "EnemyHealthRate", "GetGoldRate", "Id", "RewardCount", "RewardId", "RewardType", "ScoreBonusRate", "ShopDiscountChance",
			"SpStartCount", "SpTurnAddCount"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
