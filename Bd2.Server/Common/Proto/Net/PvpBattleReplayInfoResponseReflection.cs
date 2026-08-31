using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleReplayInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9QdnBCYXR0bGVSZXBsYXlJbmZvUmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldBonQ29tbW9ucy9QdnBCYXR0bGVVc2VyRGVja0Z1bGxJbmZv" + "LnByb3RvIr4BChtQdnBCYXR0bGVSZXBsYXlJbmZvUmVzcG9uc2USQQoTYmx1" + "ZV9kZWNrX2Z1bGxfaW5mbxgBIAEoCzIkLnByb3RvLm5ldC5QdnBCYXR0bGVV" + "c2VyRGVja0Z1bGxJbmZvEkAKEnJlZF9kZWNrX2Z1bGxfaW5mbxgCIAEoCzIk" + "LnByb3RvLm5ldC5QdnBCYXR0bGVVc2VyRGVja0Z1bGxJbmZvEhoKEmJhdHRs" + "ZV9yYW5kb21fc2VlZBgDIAMoBWIGcHJvdG8z"), new FileDescriptor[1] { PvpBattleUserDeckFullInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleReplayInfoResponse), PvpBattleReplayInfoResponse.Parser, new string[3] { "BlueDeckFullInfo", "RedDeckFullInfo", "BattleRandomSeed" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
