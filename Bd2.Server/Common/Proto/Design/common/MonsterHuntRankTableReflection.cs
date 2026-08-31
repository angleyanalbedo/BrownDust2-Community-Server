using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MonsterHuntRankTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ckdjb21tb24uZGIvTW9uc3Rlckh1bnRUYWJsZV9fX+uqrOyKpO2EsO2XjO2E" + "sC9Nb25zdGVySHVudFJhbmtUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNv" + "bW1vbiKYAQoUTW9uc3Rlckh1bnRSYW5rVGFibGUSCgoCaWQYASABKAUSFgoO" + "cmFua05hbWVUZXh0SWQYAiABKAkSDwoHcmFua2luZxgDIAEoBRIZChFzZWFz" + "b25SZXdhcmRDb3VudBgEIAMoBRIWCg5zZWFzb25SZXdhcmRJZBgFIAMoBRIY" + "ChBzZWFzb25SZXdhcmRUeXBlGAYgAygFQkRCE1Byb3RvLkRlc2lnbi5jb21t" + "b25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNv" + "bW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntRankTable), MonsterHuntRankTable.Parser, new string[6] { "Id", "RankNameTextId", "Ranking", "SeasonRewardCount", "SeasonRewardId", "SeasonRewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
