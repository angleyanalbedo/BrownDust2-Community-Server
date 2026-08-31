using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EvilCastleTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvRXZpbENhc3RsZV9f7JWF66eI7ISxL0V2aWxDYXN0bGVU" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKjBAoPRXZpbENhc3Rs" + "ZVRhYmxlEhcKD1BvaW50UG9zaXRpb25JZBgBIAEoBRITCgtSZXdhcmRDb3Vu" + "dBgCIAMoBRIQCghSZXdhcmRJZBgDIAMoBRISCgpSZXdhcmRUeXBlGAQgAygF" + "EhMKC2JhdHRsZVBvd2VyGAUgASgFEhoKEmJlc3RSZWNvcmRUaW1lbGluZRgG" + "IAEoCRIbChNib3NzRGVzY0xvY2FsVGV4dElkGAcgASgFEg4KBmJvc3NJZBgI" + "IAEoBRIWCg5ib3NzTmFtZVRleHRJZBgJIAEoBRIbChNib3NzVGFyZ2V0TG9j" + "YWxUZXh0GAogASgFEhwKFGNsZWFyRGVzY0xvY2FsVGV4dElkGAsgASgFEhcK" + "D2ZpZWxkTW9uc3RlcklkcxgMIAMoBRIcChRmbG9vckRlc2NMb2NhbFRleHRJ" + "ZBgNIAEoBRIcChRmbG9vck5hbWVMb2NhbFRleHRJZBgOIAEoBRIWCg5pY29u" + "U3ByaXRlTmFtZRgPIAEoCRIKCgJpZBgQIAEoBRINCgVtYXBJZBgRIAEoBRIR" + "Cgltb25zdGVySWQYEiADKAUSHQoVbm9ybWFsRGVzY0xvY2FsVGV4dElkGBMg" + "ASgFEh0KFW5vcm1hbFRhcmdldExvY2FsVGV4dBgUIAEoBRIcChRyZWNvcmRV" + "cGRhdGVUaW1lbGluZRgVIAEoCRIUCgx0aW1lQXR0YWNrSWQYFiABKAVCREIT" + "UHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26q" + "AhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleTable), EvilCastleTable.Parser, new string[22]
		{
			"PointPositionId", "RewardCount", "RewardId", "RewardType", "BattlePower", "BestRecordTimeline", "BossDescLocalTextId", "BossId", "BossNameTextId", "BossTargetLocalText",
			"ClearDescLocalTextId", "FieldMonsterIds", "FloorDescLocalTextId", "FloorNameLocalTextId", "IconSpriteName", "Id", "MapId", "MonsterId", "NormalDescLocalTextId", "NormalTargetLocalText",
			"RecordUpdateTimeline", "TimeAttackId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
