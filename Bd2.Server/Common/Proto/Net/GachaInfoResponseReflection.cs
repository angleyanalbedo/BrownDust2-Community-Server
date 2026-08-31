using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXNwb25zZS9HYWNoYUluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0" + "Gh1Db21tb25zL0dhY2hhVXNlckRCSW5mby5wcm90bxohQ29tbW9ucy9HYWNo" + "YVNjaGVkdWxlREJJbmZvLnByb3RvGh5Db21tb25zL0dhY2hhRml4ZWREQklu" + "Zm8ucHJvdG8aIkNvbW1vbnMvR2FjaGFTZWxlY3Rpb25EQkluZm8ucHJvdG8a" + "J0NvbW1vbnMvR2FjaGFTdGVwVXBTY2hlZHVsZURCSW5mby5wcm90bxojQ29t" + "bW9ucy9HYWNoYVN0ZXBVcFVzZXJEQkluZm8ucHJvdG8inAMKEUdhY2hhSW5m" + "b1Jlc3BvbnNlEjUKDXNjaGVkdWxlX2luZm8YASADKAsyHi5wcm90by5uZXQu" + "R2FjaGFTY2hlZHVsZURCSW5mbxIzCg9nYWNoYV91c2VyX2luZm8YAiADKAsy" + "Gi5wcm90by5uZXQuR2FjaGFVc2VyREJJbmZvEiMKG3NjaGVkdWxlX2VuZF9l" + "eGNoYW5nZV9wb2ludBgDIAEoBRI1ChBnYWNoYV9maXhlZF9pbmZvGAQgAygL" + "MhsucHJvdG8ubmV0LkdhY2hhRml4ZWREQkluZm8SPQoUZ2FjaGFfc2VsZWN0" + "aW9uX2luZm8YBSADKAsyHy5wcm90by5uZXQuR2FjaGFTZWxlY3Rpb25EQklu" + "Zm8SQwoVc3RlcF91cF9zY2hlZHVsZV9pbmZvGAYgAygLMiQucHJvdG8ubmV0" + "LkdhY2hhU3RlcFVwU2NoZWR1bGVEQkluZm8SOwoRc3RlcF91cF91c2VyX2lu" + "Zm8YByADKAsyIC5wcm90by5uZXQuR2FjaGFTdGVwVXBVc2VyREJJbmZvYgZw" + "cm90bzM="), new FileDescriptor[6]
	{
		GachaUserDBInfoReflection.Descriptor,
		GachaScheduleDBInfoReflection.Descriptor,
		GachaFixedDBInfoReflection.Descriptor,
		GachaSelectionDBInfoReflection.Descriptor,
		GachaStepUpScheduleDBInfoReflection.Descriptor,
		GachaStepUpUserDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaInfoResponse), GachaInfoResponse.Parser, new string[7] { "ScheduleInfo", "GachaUserInfo", "ScheduleEndExchangePoint", "GachaFixedInfo", "GachaSelectionInfo", "StepUpScheduleInfo", "StepUpUserInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
