using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MonsterHuntBattleTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ckljb21tb24uZGIvTW9uc3Rlckh1bnRUYWJsZV9fX+uqrOyKpO2EsO2XjO2E" + "sC9Nb25zdGVySHVudEJhdHRsZVRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24u" + "Y29tbW9uIkoKFk1vbnN0ZXJIdW50QmF0dGxlVGFibGUSEwoLYmF0dGxlUG93" + "ZXIYASABKAUSDwoHZ3JvdXBJZBgCIAEoBRIKCgJpZBgDIAEoBUJEQhNQcm90" + "by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1By" + "b3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntBattleTable), MonsterHuntBattleTable.Parser, new string[3] { "BattlePower", "GroupId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
