using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ContentRankInfoTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkRjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9D" + "b250ZW50UmFua0luZm9UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1v" + "biKNAwoUQ29udGVudFJhbmtJbmZvVGFibGUSJQodZXZpbENhc3RsZUZsb29y" + "TXlSYW5rTWF4Q291bnQYASABKAUSJgoeZXZpbENhc3RsZUZsb29yVG9wUmFu" + "a01heENvdW50GAIgASgFEiUKHWV2aWxDYXN0bGVUb3RhbE15UmFua01heENv" + "dW50GAMgASgFEiYKHmV2aWxDYXN0bGVUb3RhbFRvcFJhbmtNYXhDb3VudBgE" + "IAEoBRIKCgJpZBgFIAEoBRIfChdtaXJyb3JXYXJNeVJhbmtNYXhDb3VudBgG" + "IAEoBRIgChhtaXJyb3JXYXJUb3BSYW5rTWF4Q291bnQYByABKAUSIQoZbW9u" + "c3Rlckh1bnRNeVJhbmtNYXhDb3VudBgIIAEoBRIiChptb25zdGVySHVudFRv" + "cFJhbmtNYXhDb3VudBgJIAEoBRIfChdyb2d1ZWxpa2VNeVJhbmtNYXhDb3Vu" + "dBgKIAEoBRIgChhyb2d1ZWxpa2VUb3BSYW5rTWF4Q291bnQYCyABKAVCREIT" + "UHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26q" + "AhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ContentRankInfoTable), ContentRankInfoTable.Parser, new string[11]
		{
			"EvilCastleFloorMyRankMaxCount", "EvilCastleFloorTopRankMaxCount", "EvilCastleTotalMyRankMaxCount", "EvilCastleTotalTopRankMaxCount", "Id", "MirrorWarMyRankMaxCount", "MirrorWarTopRankMaxCount", "MonsterHuntMyRankMaxCount", "MonsterHuntTopRankMaxCount", "RoguelikeMyRankMaxCount",
			"RoguelikeTopRankMaxCount"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
