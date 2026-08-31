using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class StatueRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvRmllbGRUYWJsZV9fX+2VhOuTnC9TdGF0dWVSZXdhcmRU" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJaChFTdGF0dWVSZXdh" + "cmRUYWJsZRIKCgJpZBgBIAEoBRITCgtyZXdhcmRDb3VudBgCIAEoBRIQCghy" + "ZXdhcmRJZBgDIAEoBRISCgpyZXdhcmRUeXBlGAQgASgFQkRCE1Byb3RvLkRl" + "c2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8u" + "RGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(StatueRewardTable), StatueRewardTable.Parser, new string[4] { "Id", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
