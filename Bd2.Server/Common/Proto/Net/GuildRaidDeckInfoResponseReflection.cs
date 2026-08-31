using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidDeckInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9HdWlsZFJhaWREZWNrSW5mb1Jlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaGENvbW1vbnMvRGVja0RCSW5mby5wcm90bxoqQ29tbW9ucy9H" + "dWlsZFJhaWRTdXBwb3J0ZXJEZWNrREJJbmZvLnByb3RvIq0BChlHdWlsZFJh" + "aWREZWNrSW5mb1Jlc3BvbnNlEigKCWRlY2tfaW5mbxgBIAMoCzIVLnByb3Rv" + "Lm5ldC5EZWNrREJJbmZvEkQKE3N1cHBvcnRlcl9kZWNrX2luZm8YAiADKAsy" + "Jy5wcm90by5uZXQuR3VpbGRSYWlkU3VwcG9ydGVyRGVja0RCSW5mbxIgChhp" + "c19zdXBwb3J0ZXJfZGVja191cGRhdGUYAyABKAhiBnByb3RvMw=="), new FileDescriptor[2]
	{
		DeckDBInfoReflection.Descriptor,
		GuildRaidSupporterDeckDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidDeckInfoResponse), GuildRaidDeckInfoResponse.Parser, new string[3] { "DeckInfo", "SupporterDeckInfo", "IsSupporterDeckUpdate" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
