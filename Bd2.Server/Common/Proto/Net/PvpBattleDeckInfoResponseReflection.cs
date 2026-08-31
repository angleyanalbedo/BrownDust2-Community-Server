using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleDeckInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9QdnBCYXR0bGVEZWNrSW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaI0NvbW1vbnMvUHZwQmF0dGxlVXNlckRlY2tJbmZvLnByb3Rv" + "IpQBChlQdnBCYXR0bGVEZWNrSW5mb1Jlc3BvbnNlEjoKEGF0dGFja19kZWNr" + "X2luZm8YASADKAsyIC5wcm90by5uZXQuUHZwQmF0dGxlVXNlckRlY2tJbmZv" + "EjsKEWRlZmVuc2VfZGVja19pbmZvGAIgAygLMiAucHJvdG8ubmV0LlB2cEJh" + "dHRsZVVzZXJEZWNrSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { PvpBattleUserDeckInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleDeckInfoResponse), PvpBattleDeckInfoResponse.Parser, new string[2] { "AttackDeckInfo", "DefenseDeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
