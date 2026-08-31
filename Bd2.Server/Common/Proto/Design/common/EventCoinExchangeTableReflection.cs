using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EventCoinExchangeTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjxjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0V2ZW50Q29pbkV4" + "Y2hhbmdlVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ivgEKFkV2" + "ZW50Q29pbkV4Y2hhbmdlVGFibGUSDwoHZ3JvdXBJZBgBIAEoBRIKCgJpZBgC" + "IAEoBRIPCgdrZXlUeXBlGAMgASgFEg4KBnBhZ2VJZBgEIAEoBRINCgVyYXRp" + "bxgFIAEoBRIXCg9yZXdhcmRJdGVtQ291bnQYBiABKAUSFAoMcmV3YXJkSXRl" + "bUlkGAcgASgFEhYKDnJld2FyZEl0ZW1UeXBlGAggASgFEhAKCHNldENvdW50" + "GAkgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNp" + "Z24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventCoinExchangeTable), EventCoinExchangeTable.Parser, new string[9] { "GroupId", "Id", "KeyType", "PageId", "Ratio", "RewardItemCount", "RewardItemId", "RewardItemType", "SetCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
