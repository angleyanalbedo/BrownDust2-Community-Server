using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class RLFloorTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvUm9ndWVsaWtlX+uhnOq3uOudvOydtO2BrC9STEZsb29y" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i7QIKDFJMRmxvb3JU" + "YWJsZRIaChJib3NzQmF0dGxlTGV2ZWxNYXgYASABKAUSGgoSYm9zc0JhdHRs" + "ZUxldmVsTWluGAIgASgFEhsKE2VsaXRlQmF0dGxlTGV2ZWxNYXgYAyABKAUS" + "GwoTZWxpdGVCYXR0bGVMZXZlbE1pbhgEIAEoBRIbChNldmVudEJhdHRsZUxl" + "dmVsTWF4GAUgASgFEhsKE2V2ZW50QmF0dGxlTGV2ZWxNaW4YBiABKAUSDwoH" + "Z3JvdXBJZBgHIAEoBRIKCgJpZBgIIAEoBRIcChRub3JtYWxCYXR0bGVMZXZl" + "bE1heBgJIAEoBRIcChRub3JtYWxCYXR0bGVMZXZlbE1pbhgKIAEoBRITCgty" + "b29tR3JvdXBJZBgLIAMoBRIRCglyb29tUmF0aW8YDCADKAUSFQoNc2hvcFJv" + "b21Db3VudBgNIAEoBRIZChF0cmVhc3VyZVJvb21Db3VudBgOIAEoBUJEQhNQ" + "cm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoC" + "E1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RLFloorTable), RLFloorTable.Parser, new string[14]
		{
			"BossBattleLevelMax", "BossBattleLevelMin", "EliteBattleLevelMax", "EliteBattleLevelMin", "EventBattleLevelMax", "EventBattleLevelMin", "GroupId", "Id", "NormalBattleLevelMax", "NormalBattleLevelMin",
			"RoomGroupId", "RoomRatio", "ShopRoomCount", "TreasureRoomCount"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
