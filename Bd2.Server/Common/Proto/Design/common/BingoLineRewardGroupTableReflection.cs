using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class BingoLineRewardGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkJjb21tb24uZGIvTWluaUdhbWVfX1/rr7jri4gg6rKM7J6EL0JpbmdvTGlu" + "ZVJld2FyZEdyb3VwVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i" + "rAEKGUJpbmdvTGluZVJld2FyZEdyb3VwVGFibGUSEgoKY2xlYXJDb3VudBgB" + "IAEoBRIPCgdncm91cElkGAIgASgFEgoKAmlkGAMgASgFEhEKCWxpbmVJbmRl" + "eBgEIAEoBRIQCghsaW5lVHlwZRgFIAEoBRITCgtyZXdhcmRDb3VudBgGIAEo" + "BRIQCghyZXdhcmRJZBgHIAEoBRISCgpyZXdhcmRUeXBlGAggASgFQkRCE1By" + "b3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgIT" + "UHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BingoLineRewardGroupTable), BingoLineRewardGroupTable.Parser, new string[8] { "ClearCount", "GroupId", "Id", "LineIndex", "LineType", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
