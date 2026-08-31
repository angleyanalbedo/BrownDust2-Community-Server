using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleEndRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L0JhdHRsZUVuZFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldBoY" + "Q29tbW9ucy9DaGFyREJJbmZvLnByb3RvIroBChBCYXR0bGVFbmRSZXF1ZXN0" + "EgsKA3NlcRgBIAEoBRIVCg1iYXR0bGVfcmVzdWx0GAIgASgFEigKCWNoYXJf" + "aW5mbxgDIAMoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZvEg8KB3BhY2tfaWQY" + "BCABKAUSFQoNYWNoaWV2ZV9pbmRleBgFIAMoBRIXCg9lbmRfaW52ZW5faW5k" + "ZXgYBiADKAMSFwoPbW9uc3Rlcl9odW50X2hwGAcgASgDYgZwcm90bzM="), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleEndRequest), BattleEndRequest.Parser, new string[7] { "Seq", "BattleResult", "CharInfo", "PackId", "AchieveIndex", "EndInvenIndex", "MonsterHuntHp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
