using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class NotifyReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRDb21tb25zL05vdGlmeS5wcm90bxIJcHJvdG8ubmV0IkYKEkFjdGl2ZUNv" + "bnRlbnRzSW5mbxIKCgJpZBgBIAEoBRISCgpzdGFydF90aW1lGAIgASgDEhAK" + "CGVuZF90aW1lGAMgASgDIpIBChRNaXNzaW9uVXBkYXRlSW5mb01hcBJGCgxt" + "aXNzaW9uX2luZm8YASADKAsyMC5wcm90by5uZXQuTWlzc2lvblVwZGF0ZUlu" + "Zm9NYXAuTWlzc2lvbkluZm9FbnRyeRoyChBNaXNzaW9uSW5mb0VudHJ5EgsK" + "A2tleRgBIAEoBRINCgV2YWx1ZRgCIAEoBToCOAEiwQEKE0V2ZW50TWlzc2lv" + "bkluZm9NYXASUAoSbWlzc2lvbl9ncm91cF9pbmZvGAEgAygLMjQucHJvdG8u" + "bmV0LkV2ZW50TWlzc2lvbkluZm9NYXAuTWlzc2lvbkdyb3VwSW5mb0VudHJ5" + "GlgKFU1pc3Npb25Hcm91cEluZm9FbnRyeRILCgNrZXkYASABKAUSLgoFdmFs" + "dWUYAiABKAsyHy5wcm90by5uZXQuTWlzc2lvblVwZGF0ZUluZm9NYXA6AjgB" + "IsAFCgZOb3RpZnkSEwoLaXNfbmV3X21haWwYASABKAgSTQoXYWNoaWV2ZW1l" + "bnRfdXBkYXRlX2luZm8YAiADKAsyLC5wcm90by5uZXQuTm90aWZ5LkFjaGll" + "dmVtZW50VXBkYXRlSW5mb0VudHJ5EkUKE21pc3Npb25fdXBkYXRlX2luZm8Y" + "AyADKAsyKC5wcm90by5uZXQuTm90aWZ5Lk1pc3Npb25VcGRhdGVJbmZvRW50" + "cnkSUAoZZXZlbnRfbWlzc2lvbl91cGRhdGVfaW5mbxgEIAMoCzItLnByb3Rv" + "Lm5ldC5Ob3RpZnkuRXZlbnRNaXNzaW9uVXBkYXRlSW5mb0VudHJ5Eg8KB2xs" + "X3R5cGUYBSABKAkSHgoWaXNfcHVyY2hhc2luZ19kaXNhYmxlZBgGIAEoCBIe" + "ChZtYWludGVuYW5jZV9zdGFydF9kYXRlGAcgASgDEhcKD25vdGljZV9sYXN0" + "X3NlcRgIIAEoBRIaChJhY3RpdmVfbG9naW5fZXZlbnQYCSADKAUSOwoUYWN0" + "aXZlX2NvbnRlbnRzX2luZm8YCiADKAsyHS5wcm90by5uZXQuQWN0aXZlQ29u" + "dGVudHNJbmZvGjwKGkFjaGlldmVtZW50VXBkYXRlSW5mb0VudHJ5EgsKA2tl" + "eRgBIAEoBRINCgV2YWx1ZRgCIAEoBToCOAEaWQoWTWlzc2lvblVwZGF0ZUlu" + "Zm9FbnRyeRILCgNrZXkYASABKAUSLgoFdmFsdWUYAiABKAsyHy5wcm90by5u" + "ZXQuTWlzc2lvblVwZGF0ZUluZm9NYXA6AjgBGl0KG0V2ZW50TWlzc2lvblVw" + "ZGF0ZUluZm9FbnRyeRILCgNrZXkYASABKAUSLQoFdmFsdWUYAiABKAsyHi5w" + "cm90by5uZXQuRXZlbnRNaXNzaW9uSW5mb01hcDoCOAFiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[4]
	{
		new GeneratedClrTypeInfo(typeof(ActiveContentsInfo), ActiveContentsInfo.Parser, new string[3] { "Id", "StartTime", "EndTime" }, null, null, null, null),
		new GeneratedClrTypeInfo(typeof(MissionUpdateInfoMap), MissionUpdateInfoMap.Parser, new string[1] { "MissionInfo" }, null, null, null, new GeneratedClrTypeInfo[1]),
		new GeneratedClrTypeInfo(typeof(EventMissionInfoMap), EventMissionInfoMap.Parser, new string[1] { "MissionGroupInfo" }, null, null, null, new GeneratedClrTypeInfo[1]),
		new GeneratedClrTypeInfo(typeof(Notify), Notify.Parser, new string[10] { "IsNewMail", "AchievementUpdateInfo", "MissionUpdateInfo", "EventMissionUpdateInfo", "LlType", "IsPurchasingDisabled", "MaintenanceStartDate", "NoticeLastSeq", "ActiveLoginEvent", "ActiveContentsInfo" }, null, null, null, new GeneratedClrTypeInfo[3])
	}));

	public static FileDescriptor Descriptor => descriptor;
}
