using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleStartResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9QdnBCYXR0bGVTdGFydFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQiNAoWUHZwQmF0dGxlU3RhcnRSZXNwb25zZRIaChJiYXR0bGVfcmFuZG9tX3NlZWQYASABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleStartResponse), PvpBattleStartResponse.Parser, new string[1] { "BattleRandomSeed" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
