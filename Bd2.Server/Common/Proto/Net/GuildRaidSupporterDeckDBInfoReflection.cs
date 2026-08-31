using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidSupporterDeckDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipDb21tb25zL0d1aWxkUmFpZFN1cHBvcnRlckRlY2tEQkluZm8ucHJvdG8SCXByb3RvLm5ldCJrChxHdWlsZFJhaWRTdXBwb3J0ZXJEZWNrREJJbmZvEhMKC293bmVyX2luZGV4GAEgASgDEhIKCnNsb3RfaW5kZXgYAiABKAUSEAoIcG9zaXRpb24YAyABKAUSEAoIc2VxdWVuY2UYBCABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidSupporterDeckDBInfo), GuildRaidSupporterDeckDBInfo.Parser, new string[4] { "OwnerIndex", "SlotIndex", "Position", "Sequence" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
