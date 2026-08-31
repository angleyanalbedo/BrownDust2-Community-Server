using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleResetResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9QdnBCYXR0bGVSZXNldFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQiZwoWUHZwQmF0dGxlUmVzZXRSZXNwb25zZRIlCh1kZWNrX3NlYXNvbl9hdHRhY2tfcmVzZXRfZGF0ZRgBIAEoAxImCh5kZWNrX3NlYXNvbl9kZWZlbnNlX3Jlc2V0X2RhdGUYAiABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleResetResponse), PvpBattleResetResponse.Parser, new string[2] { "DeckSeasonAttackResetDate", "DeckSeasonDefenseResetDate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
