using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleHistoryDeckInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9SZXNwb25zZS9QdnBCYXR0bGVIaXN0b3J5RGVja0luZm9SZXNwb25zZS5w" + "cm90bxIJcHJvdG8ubmV0GidDb21tb25zL1B2cEJhdHRsZVVzZXJEZWNrRnVs" + "bEluZm8ucHJvdG8iqQEKIFB2cEJhdHRsZUhpc3RvcnlEZWNrSW5mb1Jlc3Bv" + "bnNlEkEKE3VzZXJfZGVja19mdWxsX2luZm8YASABKAsyJC5wcm90by5uZXQu" + "UHZwQmF0dGxlVXNlckRlY2tGdWxsSW5mbxJCChRlbmVteV9kZWNrX2Z1bGxf" + "aW5mbxgCIAEoCzIkLnByb3RvLm5ldC5QdnBCYXR0bGVVc2VyRGVja0Z1bGxJ" + "bmZvYgZwcm90bzM="), new FileDescriptor[1] { PvpBattleUserDeckFullInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleHistoryDeckInfoResponse), PvpBattleHistoryDeckInfoResponse.Parser, new string[2] { "UserDeckFullInfo", "EnemyDeckFullInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
