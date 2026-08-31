using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SpecialScoutInfoTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkRjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL1Nw" + "ZWNpYWxTY291dEluZm9UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1v" + "biKzAQoVU3BlY2lhbFNjb3V0SW5mb1RhYmxlEhgKEGFwcGVhclRvdGFsQ291" + "bnQYASABKAUSFwoPYXV0b1Jlc2V0TWludXRlGAIgASgFEgoKAmlkGAMgASgF" + "EhYKDnJlc2V0Q29zdENvdW50GAQgASgFEhMKC3Jlc2V0Q29zdElkGAUgASgF" + "EhUKDXJlc2V0Q29zdFR5cGUYBiABKAUSFwoPcmVzZXRMaW1pdENvdW50GAcg" + "ASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24u" + "Y29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SpecialScoutInfoTable), SpecialScoutInfoTable.Parser, new string[7] { "AppearTotalCount", "AutoResetMinute", "Id", "ResetCostCount", "ResetCostId", "ResetCostType", "ResetLimitCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
