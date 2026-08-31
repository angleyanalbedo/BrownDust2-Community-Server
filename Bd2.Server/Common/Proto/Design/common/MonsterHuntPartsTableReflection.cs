using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MonsterHuntPartsTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ckhjb21tb24uZGIvTW9uc3Rlckh1bnRUYWJsZV9fX+uqrOyKpO2EsO2XjO2E" + "sC9Nb25zdGVySHVudFBhcnRzVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5j" + "b21tb24i+AEKFU1vbnN0ZXJIdW50UGFydHNUYWJsZRIYChBib3NzQm9keVBv" + "c2l0aW9uGAEgASgFEhUKDWJvc3NQYXJ0SWNvbjEYAiABKAkSFQoNYm9zc1Bh" + "cnRJY29uMhgDIAEoCRITCgtjb25kaXRpb25JZBgEIAEoBRIPCgdncm91cElk" + "GAUgASgFEgoKAmlkGAYgASgFEhQKDHBhcmVudENoYXJJZBgHIAEoBRIXCg9w" + "YXJ0TG9jYWxUZXh0SWQYCCABKAUSDAoEdHlwZRgJIAEoBRISCgp1c2VDb3N0" + "dW1lGAogASgFEhQKDHdlYWtEbWdWYWx1ZRgLIAEoAUJEQhNQcm90by5EZXNp" + "Z24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRl" + "c2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntPartsTable), MonsterHuntPartsTable.Parser, new string[11]
		{
			"BossBodyPosition", "BossPartIcon1", "BossPartIcon2", "ConditionId", "GroupId", "Id", "ParentCharId", "PartLocalTextId", "Type", "UseCostume",
			"WeakDmgValue"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
