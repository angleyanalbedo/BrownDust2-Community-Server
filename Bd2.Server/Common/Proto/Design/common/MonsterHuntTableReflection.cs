using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MonsterHuntTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkNjb21tb24uZGIvTW9uc3Rlckh1bnRUYWJsZV9fX+uqrOyKpO2EsO2XjO2E" + "sC9Nb25zdGVySHVudFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9u" + "IrQEChBNb25zdGVySHVudFRhYmxlEhQKDGJhdHRsZURlY2tJZBgBIAEoBRIb" + "ChNib3NzVGlwMkxvY2FsVGV4dElkGAIgASgFEhoKEmJvc3NUaXBMb2NhbFRl" + "eHRJZBgDIAEoBRIWCg5ib3NzVXBUaW1lbGluZRgEIAEoCRISCgpkZXNjVGV4" + "dElkGAUgASgFEhkKEWZpcnN0Qm9zc1RpbWVsaW5lGAYgASgJEhgKEGZpeENy" + "aXRpY2FsQ2hhaW4YByABKAUSCgoCaWQYCCABKAUSGQoRbGV2ZWxVcERhbWFn" + "ZVJhdGUYCSABKAESGgoSbGV2ZWxVcERhbWFnZVNsb3BlGAogASgBEhkKEWxl" + "dmVsVXBIZWFsdGhSYXRlGAsgASgBEhoKEmxldmVsVXBIZWFsdGhTbG9wZRgM" + "IAEoARINCgVtYXBJZBgNIAEoBRIRCgltb25zdGVySWQYDiABKAUSFgoOb3Bl" + "bkxldmVsVmFsdWUYDyABKAUSDgoGcGFja0lkGBAgASgFEhQKDHBhcnRzR3Jv" + "dXBJZBgRIAEoBRIPCgdwb2ludElkGBIgASgFEhUKDXBvc2l0aW9uU2NhbGUY" + "EyABKAESFQoNcmV3YXJkR3JvdXBJZBgUIAEoBRITCgtyZXdhcmRMZXZlbBgV" + "IAEoBRIVCg1zdGFydFRpbWVsaW5lGBYgASgJEhQKDHN0YXR1ZVBhY2tJZBgX" + "IAEoBRIVCg10ZWFtT3BlbkxldmVsGBggAygFQkRCE1Byb3RvLkRlc2lnbi5j" + "b21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWdu" + "LmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntTable), MonsterHuntTable.Parser, new string[24]
		{
			"BattleDeckId", "BossTip2LocalTextId", "BossTipLocalTextId", "BossUpTimeline", "DescTextId", "FirstBossTimeline", "FixCriticalChain", "Id", "LevelUpDamageRate", "LevelUpDamageSlope",
			"LevelUpHealthRate", "LevelUpHealthSlope", "MapId", "MonsterId", "OpenLevelValue", "PackId", "PartsGroupId", "PointId", "PositionScale", "RewardGroupId",
			"RewardLevel", "StartTimeline", "StatuePackId", "TeamOpenLevel"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
