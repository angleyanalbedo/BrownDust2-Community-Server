using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidPlayDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDb21tb25zL0d1aWxkUmFpZFBsYXlEQkluZm8ucHJvdG8SCXByb3RvLm5l" + "dBoUQ29tbW9ucy9EZWZpbmUucHJvdG8ixQEKE0d1aWxkUmFpZFBsYXlEQklu" + "Zm8SEgoKYm9zc19zY29yZRgBIAEoAxITCgt0b3RhbF9zY29yZRgCIAEoBRIT" + "Cgt0b3BfcGVyY2VudBgDIAEoARIaChJpc19wbGF5X3JhaWRfdG9kYXkYBCAB" + "KAgSHQoVaXNfbm9ybWFsX2JhdHRsZV9wbGF5GAUgASgIEjUKC2JhdHRsZV9t" + "b2RlGAYgASgOMiAucHJvdG8ubmV0LkRlZmluZV9CYXR0bGVNb2RlVHlwZWIG" + "cHJvdG8z"), new FileDescriptor[1] { DefineReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidPlayDBInfo), GuildRaidPlayDBInfo.Parser, new string[6] { "BossScore", "TotalScore", "TopPercent", "IsPlayRaidToday", "IsNormalBattlePlay", "BattleMode" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
