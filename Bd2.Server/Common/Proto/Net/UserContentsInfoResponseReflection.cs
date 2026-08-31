using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UserContentsInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9Vc2VyQ29udGVudHNJbmZvUmVzcG9uc2UucHJvdG8SCXBy" + "b3RvLm5ldBocQ29tbW9ucy9NeVJvb21Vc2VySW5mby5wcm90bxodQ29tbW9u" + "cy9HdWlsZEJhc2VEQkluZm8ucHJvdG8i0gMKGFVzZXJDb250ZW50c0luZm9S" + "ZXNwb25zZRITCgtvd25lcl9pbmRleBgBIAEoAxIPCgd1c2VyX2lkGAIgASgJ" + "EhAKCHRpdGxlX2lkGAMgASgFEhsKE3BvcnRyYWl0X2Nvc3R1bWVfaWQYBCAB" + "KAUSEAoIZ3JlZXRpbmcYBSABKAkSEgoKcHZwX3NlYXNvbhgGIAEoBRIOCgZw" + "dnBfdnAYByABKAUSEAoIcHZwX3JhbmsYCCABKAUSFwoPZXZpbGNhc3RsZV9y" + "YW5rGAkgASgFEhgKEG1vbnN0ZXJodW50X3JhbmsYCiABKAUSEgoKbGlrZV9j" + "b3VudBgLIAEoBRIWCg5pc19hbGxfcHJpdmF0ZRgMIAEoCBIPCgdvcHRpb25z" + "GA0gAygFEhEKCWlzX2ZyaWVuZBgOIAEoCBIsCglyb29tX2luZm8YDyABKAsy" + "GS5wcm90by5uZXQuTXlSb29tVXNlckluZm8SFwoPdG90YWxfd2FyX3Njb3Jl" + "GBAgASgDEhoKEnRvdGFsX2JhdHRsZV9wb3dlchgRIAEoBRIzCg9ndWlsZF9i" + "YXNlX2luZm8YEiABKAsyGi5wcm90by5uZXQuR3VpbGRCYXNlREJJbmZvYgZw" + "cm90bzM="), new FileDescriptor[2]
	{
		MyRoomUserInfoReflection.Descriptor,
		GuildBaseDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserContentsInfoResponse), UserContentsInfoResponse.Parser, new string[18]
		{
			"OwnerIndex", "UserId", "TitleId", "PortraitCostumeId", "Greeting", "PvpSeason", "PvpVp", "PvpRank", "EvilcastleRank", "MonsterhuntRank",
			"LikeCount", "IsAllPrivate", "Options", "IsFriend", "RoomInfo", "TotalWarScore", "TotalBattlePower", "GuildBaseInfo"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
