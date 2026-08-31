using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class DeckInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9EZWNrSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvRGVja0RCSW5mby5wcm90byJWChBEZWNrSW5mb1Jlc3BvbnNlEigKCWRlY2tfaW5mbxgBIAMoCzIVLnByb3RvLm5ldC5EZWNrREJJbmZvEhgKEHRhbGVudF9zbG90X2luZm8YAiADKAViBnByb3RvMw=="), new FileDescriptor[1] { DeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(DeckInfoResponse), DeckInfoResponse.Parser, new string[2] { "DeckInfo", "TalentSlotInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
