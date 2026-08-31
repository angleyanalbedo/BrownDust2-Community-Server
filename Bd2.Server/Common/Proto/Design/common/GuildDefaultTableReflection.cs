using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GuildDefaultTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9jb21tb24uZGIvR3VpbGRfX+q4uOuTnC9HdWlsZERlZmF1bHRUYWJsZS5w" + "cm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLtAwoRR3VpbGREZWZhdWx0VGFi" + "bGUSFwoPY2hhdERlbGV0ZUNvdW50GAEgASgFEhYKDmNoYXREZWxldGVUaW1l" + "GAIgASgFEiIKGmd1aWxkQXR0ZW5kYW5jZVJld2FyZENvdW50GAMgASgFEh8K" + "F2d1aWxkQXR0ZW5kYW5jZVJld2FyZElkGAQgASgFEiEKGWd1aWxkQXR0ZW5k" + "YW5jZVJld2FyZFR5cGUYBSABKAUSHAoUZ3VpbGRDcmVhdGVJdGVtQ291bnQY" + "BiABKAUSGQoRZ3VpbGRDcmVhdGVJdGVtSWQYByABKAUSGwoTZ3VpbGRDcmVh" + "dGVJdGVtVHlwZRgIIAEoBRIdChVndWlsZERlbGV0ZUNhbmNlbFRpbWUYCSAB" + "KAUSFAoMZ3VpbGRHdWlkZUlkGAogASgFEhYKDmd1aWxkTGlzdENvdW50GAsg" + "ASgFEhsKE2d1aWxkTWF4TWVtYmVyQ291bnQYDCABKAUSGgoSZ3VpbGRTaWdu" + "RGVsYXlUaW1lGA0gASgFEhoKEmd1aWxkU2lnbkxpc3RDb3VudBgOIAEoBRIi" + "ChpndWlsZFNpZ25SZXF1ZXN0RXhwaXJlVGltZRgPIAEoBRIKCgJpZBgQIAEo" + "BRIXCg9wcmVHdWlsZEd1aWRlSWQYESABKAVCREITUHJvdG8uRGVzaWduLmNv" + "bW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24u" + "Y29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuildDefaultTable), GuildDefaultTable.Parser, new string[17]
		{
			"ChatDeleteCount", "ChatDeleteTime", "GuildAttendanceRewardCount", "GuildAttendanceRewardId", "GuildAttendanceRewardType", "GuildCreateItemCount", "GuildCreateItemId", "GuildCreateItemType", "GuildDeleteCancelTime", "GuildGuideId",
			"GuildListCount", "GuildMaxMemberCount", "GuildSignDelayTime", "GuildSignListCount", "GuildSignRequestExpireTime", "Id", "PreGuildGuideId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
