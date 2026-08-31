using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidDeckSaveResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9HdWlsZFJhaWREZWNrU2F2ZVJlc3BvbnNlLnByb3RvEglwcm90by5uZXQiOAoZR3VpbGRSYWlkRGVja1NhdmVSZXNwb25zZRIbChNpc19zdXBwb3J0ZXJfdXBkYXRlGAEgASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidDeckSaveResponse), GuildRaidDeckSaveResponse.Parser, new string[1] { "IsSupporterUpdate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
