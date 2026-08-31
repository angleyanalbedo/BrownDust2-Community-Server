using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleStartResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9CYXR0bGVTdGFydFJlc3BvbnNlLnByb3RvEglwcm90by5u" + "ZXQaHkNvbW1vbnMvQmF0dGxlQ2hhckRCSW5mby5wcm90byKaAQoTQmF0dGxl" + "U3RhcnRSZXNwb25zZRIyCg1yZWRfY2hhcl9pbmZvGAEgAygLMhsucHJvdG8u" + "bmV0LkJhdHRsZUNoYXJEQkluZm8SMwoOYmx1ZV9jaGFyX2luZm8YAiADKAsy" + "Gy5wcm90by5uZXQuQmF0dGxlQ2hhckRCSW5mbxIaChJiYXR0bGVfcmFuZG9t" + "X3NlZWQYAyABKAViBnByb3RvMw=="), new FileDescriptor[1] { BattleCharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleStartResponse), BattleStartResponse.Parser, new string[3] { "RedCharInfo", "BlueCharInfo", "BattleRandomSeed" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
