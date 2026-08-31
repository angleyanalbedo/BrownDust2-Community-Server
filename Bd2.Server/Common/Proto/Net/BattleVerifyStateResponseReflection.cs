using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleVerifyStateResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9CYXR0bGVWZXJpZnlTdGF0ZVJlc3BvbnNlLnByb3RvEglw" + "cm90by5uZXQaFENvbW1vbnMvRGVmaW5lLnByb3RvGh5Db21tb25zL0JhdHRs" + "ZUNoYXJEQkluZm8ucHJvdG8iwgEKGUJhdHRsZVZlcmlmeVN0YXRlUmVzcG9u" + "c2USDQoFc3RhdGUYASABKAUSLQoJdGVhbV90eXBlGAIgASgOMhoucHJvdG8u" + "bmV0LkRlZmluZV9UZWFtVHlwZRIyCg1yZWRfY2hhcl9pbmZvGAMgAygLMhsu" + "cHJvdG8ubmV0LkJhdHRsZUNoYXJEQkluZm8SMwoOYmx1ZV9jaGFyX2luZm8Y" + "BCADKAsyGy5wcm90by5uZXQuQmF0dGxlQ2hhckRCSW5mb2IGcHJvdG8z"), new FileDescriptor[2]
	{
		DefineReflection.Descriptor,
		BattleCharDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleVerifyStateResponse), BattleVerifyStateResponse.Parser, new string[4] { "State", "TeamType", "RedCharInfo", "BlueCharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
