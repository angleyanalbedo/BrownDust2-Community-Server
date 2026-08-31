using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SkyWayFieldTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvU2t5V2F5X19f66qo7ZeY7ZWt66GcL1NreVdheUZpZWxk" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ingMKEFNreVdheUZp" + "ZWxkVGFibGUSDgoGYXBUeXBlGAEgASgFEhMKC2JhdHRsZVBvd2VyGAIgASgF" + "Eg4KBmJvc3NBcBgDIAEoBRIOCgZib3NzSWQYBCABKAUSFwoPZGVzY0xvY2Fs" + "VGV4dElkGAUgASgFEhIKCmRpZmZpY3VsdHkYBiABKAUSGgoSZGlzcGxheVJl" + "d2FyZENvdW50GAcgAygFEhcKD2Rpc3BsYXlSZXdhcmRJZBgIIAMoBRIZChFk" + "aXNwbGF5UmV3YXJkVHlwZRgJIAMoBRIPCgdncm91cElkGAogASgFEhYKDmlj" + "b25TcHJpdGVOYW1lGAsgASgJEgoKAmlkGAwgASgFEg0KBW1hcElkGA0gASgF" + "EhEKCW1vbnN0ZXJBcBgOIAMoBRIRCgltb25zdGVySWQYDyADKAUSFwoPbmFt" + "ZUxvY2FsVGV4dElkGBAgASgFEhcKD3BvaW50UG9zaXRpb25JZBgRIAEoBRIV" + "Cg1wb3NpdGlvbkdyb3VwGBIgASgFEhUKDXdvcmxkTWFwUGluSWQYEyABKAVC" + "REITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21t" + "b26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkyWayFieldTable), SkyWayFieldTable.Parser, new string[19]
		{
			"ApType", "BattlePower", "BossAp", "BossId", "DescLocalTextId", "Difficulty", "DisplayRewardCount", "DisplayRewardId", "DisplayRewardType", "GroupId",
			"IconSpriteName", "Id", "MapId", "MonsterAp", "MonsterId", "NameLocalTextId", "PointPositionId", "PositionGroup", "WorldMapPinId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
