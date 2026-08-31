using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleStartRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXF1ZXN0L0JhdHRsZVN0YXJ0UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0" + "GhhDb21tb25zL0RlY2tEQkluZm8ucHJvdG8aHkNvbW1vbnMvQmF0dGxlQ2hh" + "ckRCSW5mby5wcm90bxofQ29tbW9ucy9CYXR0bGVHb2xlbURCSW5mby5wcm90" + "byL+AQoSQmF0dGxlU3RhcnRSZXF1ZXN0EgsKA3NlcRgBIAEoBRIUCgxiYXR0" + "bGVfaW5kZXgYAiABKAUSKgoLYmF0dGxlX2RlY2sYAyADKAsyFS5wcm90by5u" + "ZXQuRGVja0RCSW5mbxIyCg1yZWRfY2hhcl9pbmZvGAQgAygLMhsucHJvdG8u" + "bmV0LkJhdHRsZUNoYXJEQkluZm8SMwoOYmx1ZV9jaGFyX2luZm8YBSADKAsy" + "Gy5wcm90by5uZXQuQmF0dGxlQ2hhckRCSW5mbxIwCgpnb2xlbV9pbmZvGAYg" + "ASgLMhwucHJvdG8ubmV0LkJhdHRsZUdvbGVtREJJbmZvYgZwcm90bzM="), new FileDescriptor[3]
	{
		DeckDBInfoReflection.Descriptor,
		BattleCharDBInfoReflection.Descriptor,
		BattleGolemDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleStartRequest), BattleStartRequest.Parser, new string[6] { "Seq", "BattleIndex", "BattleDeck", "RedCharInfo", "BlueCharInfo", "GolemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
