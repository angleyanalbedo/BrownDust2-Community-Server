using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GuildRaidBossBattleInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXNwb25zZS9HdWlsZFJhaWRCb3NzQmF0dGxlSW5mb1Jlc3BvbnNlLnBy" + "b3RvEglwcm90by5uZXQitwIKH0d1aWxkUmFpZEJvc3NCYXR0bGVJbmZvUmVz" + "cG9uc2USGQoRZ3VpbGRfdG90YWxfc2NvcmUYASABKAMSGQoRZ3VpbGRfdG9w" + "X3BlcmNlbnQYAiABKAESFQoNaGlnaGVzdF9sZXZlbBgDIAEoBRIVCg1oaWdo" + "ZXN0X3Njb3JlGAQgASgDEhsKE3RvZGF5X2hpZ2hlc3RfbGV2ZWwYBSABKAUS" + "GwoTdG9kYXlfaGlnaGVzdF9zY29yZRgGIAEoAxIgChhpc19wb3NzaWJsZV9x" + "dWlja19iYXR0bGUYByABKAgSHgoWdG9wX21lbWJlcl9vd25lcl9pbmRleBgI" + "IAEoAxIaChJ0b3BfbWVtYmVyX3VzZXJfaWQYCSABKAkSGAoQdG9wX21lbWJl" + "cl9zY29yZRgKIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildRaidBossBattleInfoResponse), GuildRaidBossBattleInfoResponse.Parser, new string[10] { "GuildTotalScore", "GuildTopPercent", "HighestLevel", "HighestScore", "TodayHighestLevel", "TodayHighestScore", "IsPossibleQuickBattle", "TopMemberOwnerIndex", "TopMemberUserId", "TopMemberScore" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
