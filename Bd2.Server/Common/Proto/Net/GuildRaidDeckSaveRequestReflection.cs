using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidDeckSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0d1aWxkUmFpZERlY2tTYXZlUmVxdWVzdC5wcm90bxIJcHJv" + "dG8ubmV0GhhDb21tb25zL0RlY2tEQkluZm8ucHJvdG8aKkNvbW1vbnMvR3Vp" + "bGRSYWlkU3VwcG9ydGVyRGVja0RCSW5mby5wcm90byKXAQoYR3VpbGRSYWlk" + "RGVja1NhdmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRIoCglkZWNrX2luZm8YAiAD" + "KAsyFS5wcm90by5uZXQuRGVja0RCSW5mbxJEChNzdXBwb3J0ZXJfZGVja19p" + "bmZvGAMgAygLMicucHJvdG8ubmV0Lkd1aWxkUmFpZFN1cHBvcnRlckRlY2tE" + "QkluZm9iBnByb3RvMw=="), new FileDescriptor[2]
	{
		DeckDBInfoReflection.Descriptor,
		GuildRaidSupporterDeckDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidDeckSaveRequest), GuildRaidDeckSaveRequest.Parser, new string[3] { "Seq", "DeckInfo", "SupporterDeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
