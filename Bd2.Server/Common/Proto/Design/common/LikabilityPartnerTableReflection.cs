using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class LikabilityPartnerTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkVjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0xp" + "a2FiaWxpdHlQYXJ0bmVyVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21t" + "b24irAEKFkxpa2FiaWxpdHlQYXJ0bmVyVGFibGUSCgoCaWQYASABKAUSIAoY" + "bWFpbkNoYXJhY3RlclBvaW50V2VpZ2h0GAIgASgBEhgKEHBhcnRuZXJVbmlx" + "dWVJZHMYAyADKAUSEwoLcmV3YXJkQ291bnQYBCADKAUSEAoIcmV3YXJkSWQY" + "BSADKAUSEgoKcmV3YXJkVHlwZRgGIAMoBRIPCgdzdG9yeUlkGAcgAygFQkRC" + "E1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9u" + "qgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LikabilityPartnerTable), LikabilityPartnerTable.Parser, new string[7] { "Id", "MainCharacterPointWeight", "PartnerUniqueIds", "RewardCount", "RewardId", "RewardType", "StoryId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
