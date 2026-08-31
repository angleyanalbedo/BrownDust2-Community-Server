using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class FieldMiniGameSpeedTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkBjb21tb24uZGIvTWluaUdhbWVfX1/rr7jri4gg6rKM7J6EL0ZpZWxkTWlu" + "aUdhbWVTcGVlZFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIpsC" + "ChdGaWVsZE1pbmlHYW1lU3BlZWRUYWJsZRIUCgxib29zdGVyU3BlZWQYASAB" + "KAESEwoLYm9vc3RlclRpbWUYAiABKAUSEQoJY2xlYXJUaW1lGAMgASgFEhUK" + "DWRlY3JlYXNlVmFsdWUYBCABKAUSFQoNZ2hvc3RQb3NpdGlvbhgFIAEoBRIT" + "CgtnaG9zdFByZWZhYhgGIAEoCRIKCgJpZBgHIAEoBRIQCghtYXhDb3VudBgI" + "IAEoBRIVCg1vYmplY3RHcm91cElkGAkgASgFEhAKCHJ1bkNvdW50GAogAygF" + "EhAKCHJ1blNwZWVkGAsgAygCEhAKCHJ1blZhbHVlGAwgASgFEhQKDHN0YXJ0" + "SHBQb2ludBgNIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJv" + "dG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMiniGameSpeedTable), FieldMiniGameSpeedTable.Parser, new string[13]
		{
			"BoosterSpeed", "BoosterTime", "ClearTime", "DecreaseValue", "GhostPosition", "GhostPrefab", "Id", "MaxCount", "ObjectGroupId", "RunCount",
			"RunSpeed", "RunValue", "StartHpPoint"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
