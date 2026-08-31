using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class BingoRewardGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj5jb21tb24uZGIvTWluaUdhbWVfX1/rr7jri4gg6rKM7J6EL0JpbmdvUmV3" + "YXJkR3JvdXBUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKDAQoV" + "QmluZ29SZXdhcmRHcm91cFRhYmxlEhIKCmNsZWFyQ291bnQYASABKAUSDwoH" + "Z3JvdXBJZBgCIAEoBRIKCgJpZBgDIAEoBRITCgtyZXdhcmRDb3VudBgEIAEo" + "BRIQCghyZXdhcmRJZBgFIAEoBRISCgpyZXdhcmRUeXBlGAYgASgFQkRCE1By" + "b3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgIT" + "UHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BingoRewardGroupTable), BingoRewardGroupTable.Parser, new string[6] { "ClearCount", "GroupId", "Id", "RewardCount", "RewardId", "RewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
