using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleStartRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L1B2cEJhdHRsZVN0YXJ0UmVxdWVzdC5wcm90bxIJcHJvdG8u" + "bmV0GiNDb21tb25zL1B2cEJhdHRsZVVzZXJEZWNrSW5mby5wcm90bxoeQ29t" + "bW9ucy9CYXR0bGVDaGFyREJJbmZvLnByb3RvIsIBChVQdnBCYXR0bGVTdGFy" + "dFJlcXVlc3QSCwoDc2VxGAEgASgFEjMKCWRlY2tfaW5mbxgCIAMoCzIgLnBy" + "b3RvLm5ldC5QdnBCYXR0bGVVc2VyRGVja0luZm8SMgoNcmVkX2NoYXJfaW5m" + "bxgDIAMoCzIbLnByb3RvLm5ldC5CYXR0bGVDaGFyREJJbmZvEjMKDmJsdWVf" + "Y2hhcl9pbmZvGAQgAygLMhsucHJvdG8ubmV0LkJhdHRsZUNoYXJEQkluZm9i" + "BnByb3RvMw=="), new FileDescriptor[2]
	{
		PvpBattleUserDeckInfoReflection.Descriptor,
		BattleCharDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleStartRequest), PvpBattleStartRequest.Parser, new string[4] { "Seq", "DeckInfo", "RedCharInfo", "BlueCharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
