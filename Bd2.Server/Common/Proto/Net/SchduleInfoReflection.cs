using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SchduleInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDb21tb25zL1NjaGR1bGVJbmZvLnByb3RvEglwcm90by5uZXQiQgoKU2Vh" + "c29uSW5mbxIOCgZzZWFzb24YASABKAUSEgoKc3RhcnRfdGltZRgCIAEoAxIQ" + "CghlbmRfdGltZRgDIAEoAyJ/Cg5TY2hlZHVsZURCSW5mbxISCgpjb250ZW50" + "X2lkGAEgASgFEi0KDmN1cnJlbnRfc2Vhc29uGAIgASgLMhUucHJvdG8ubmV0" + "LlNlYXNvbkluZm8SKgoLbmV4dF9zZWFzb24YAyABKAsyFS5wcm90by5uZXQu" + "U2Vhc29uSW5mbyKQAQoXTW9uc3Rlckh1bnRTY2hlZHVsZUluZm8SKQoKc2Vh" + "c29uSW5mbxgBIAEoCzIVLnByb3RvLm5ldC5TZWFzb25JbmZvEhcKD21vbnN0" + "ZXJfaHVudF9pZBgCIAEoBRIVCg1pbmZvX29wZW5fZGF5GAMgASgFEhoKEmNh" + "bGN1bGF0ZV9lbmRfZGF0ZRgEIAEoAyJFChpNb25zdGVySHVudFNjaGVkdWxl" + "SGlzdG9yeRIOCgZzZWFzb24YASABKAUSFwoPbW9uc3Rlcl9odW50X2lkGAIg" + "ASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[4]
	{
		new GeneratedClrTypeInfo(typeof(SeasonInfo), SeasonInfo.Parser, new string[3] { "Season", "StartTime", "EndTime" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(ScheduleDBInfo), ScheduleDBInfo.Parser, new string[3] { "ContentId", "CurrentSeason", "NextSeason" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(MonsterHuntScheduleInfo), MonsterHuntScheduleInfo.Parser, new string[4] { "SeasonInfo", "MonsterHuntId", "InfoOpenDay", "CalculateEndDate" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(MonsterHuntScheduleHistory), MonsterHuntScheduleHistory.Parser, new string[2] { "Season", "MonsterHuntId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
