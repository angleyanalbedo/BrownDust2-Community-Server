using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDb21tb25zL01pbmlHYW1lREJJbmZvLnByb3RvEglwcm90by5uZXQikwIK" + "Dk1pbmlHYW1lREJJbmZvEhkKEWV2ZW50X3NjaGVkdWxlX2lkGAEgASgFEhkK" + "EWxhc3RfcmV3YXJkX3BvaW50GAIgASgFEhkKEWJlc3RfcmVjb3JkX3ZhbHVl" + "GAMgASgFEiAKGGlzX3Bvc3NpYmxlX3F1aWNrX3Jld2FyZBgEIAEoCBIlCh13" + "b3JsZF9iZXN0X3JlY29yZF9vd25lcl9pbmRleBgFIAEoAxIhChl3b3JsZF9i" + "ZXN0X3JlY29yZF91c2VyX2lkGAYgASgJEh8KF3dvcmxkX2Jlc3RfcmVjb3Jk" + "X3ZhbHVlGAcgASgFEiMKG3dvcmxkX2Jlc3RfcmVjb3JkX3BsYXlfaW5mbxgI" + "IAEoCWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameDBInfo), MiniGameDBInfo.Parser, new string[8] { "EventScheduleId", "LastRewardPoint", "BestRecordValue", "IsPossibleQuickReward", "WorldBestRecordOwnerIndex", "WorldBestRecordUserId", "WorldBestRecordValue", "WorldBestRecordPlayInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
