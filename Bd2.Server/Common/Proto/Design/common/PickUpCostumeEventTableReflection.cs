using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PickUpCostumeEventTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L1BpY2tVcENvc3R1" + "bWVFdmVudFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIpEBChdQ" + "aWNrVXBDb3N0dW1lRXZlbnRUYWJsZRIUCgxhZGRCb251c1JhdGUYASADKAIS" + "EQoJY29zdHVtZUlkGAIgASgFEg8KB2dyb3VwSWQYAyABKAUSCgoCaWQYBCAB" + "KAUSFgoOdGFyZ2V0UmV3YXJkSWQYBSADKAUSGAoQdGFyZ2V0UmV3YXJkVHlw" + "ZRgGIAMoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVz" + "aWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PickUpCostumeEventTable), PickUpCostumeEventTable.Parser, new string[6] { "AddBonusRate", "CostumeId", "GroupId", "Id", "TargetRewardId", "TargetRewardType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
