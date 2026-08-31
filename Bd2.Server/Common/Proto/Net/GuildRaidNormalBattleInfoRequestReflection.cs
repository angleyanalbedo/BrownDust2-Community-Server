using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidNormalBattleInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXF1ZXN0L0d1aWxkUmFpZE5vcm1hbEJhdHRsZUluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiQQogR3VpbGRSYWlkTm9ybWFsQmF0dGxlSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFEhAKCHJhaWRfZGF5GAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidNormalBattleInfoRequest), GuildRaidNormalBattleInfoRequest.Parser, new string[2] { "Seq", "RaidDay" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
