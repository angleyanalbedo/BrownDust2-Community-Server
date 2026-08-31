using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SquadLevelTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvU3F1YWRMZXZlbFRhYmxlX19f67aA64yA66CI67KoL1Nx" + "dWFkTGV2ZWxUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJpCg9T" + "cXVhZExldmVsVGFibGUSCgoCaWQYASABKAUSDwoHbmVlZEVYUBgCIAEoBRIT" + "CgtyZXdhcmRDb3VudBgDIAMoBRIQCghyZXdhcmRJZBgEIAMoBRISCgpyZXdh" + "cmRUeXBlGAUgAygFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90" + "by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SquadLevelTable), SquadLevelTable.Parser, new string[5] { "Id", "NeedEXP", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
