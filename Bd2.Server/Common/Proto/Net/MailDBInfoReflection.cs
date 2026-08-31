using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MailDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb21tb25zL01haWxEQkluZm8ucHJvdG8SCXByb3RvLm5ldCK6AgoKTWFp" + "bERCSW5mbxITCgtpbnZlbl9pbmRleBgBIAEoAxIMCgR0eXBlGAIgASgFEg8K" + "B21haWxfaWQYAyABKAUSEwoLc2VuZGVyX3RleHQYBCABKAkSEgoKdGl0bGVf" + "dGV4dBgFIAEoCRIUCgxtZXNzYWdlX3RleHQYBiABKAkSGgoScmV3YXJkX2V4" + "cGlyZV90aW1lGAcgASgDEhEKCWl0ZW1fdHlwZRgIIAMoBRIPCgdpdGVtX2lk" + "GAkgAygFEhIKCml0ZW1fY291bnQYCiADKAUSDwoHaXNfb3BlbhgLIAEoCBIR" + "CglvcGVuX3RpbWUYDCABKAMSEwoLY3JlYXRlX3RpbWUYDSABKAMSGwoTaGlz" + "dG9yeV9kZWxldGVfdGltZRgOIAEoAxIPCgdpc19jYXNoGA8gASgIYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MailDBInfo), MailDBInfo.Parser, new string[15]
		{
			"InvenIndex", "Type", "MailId", "SenderText", "TitleText", "MessageText", "RewardExpireTime", "ItemType", "ItemId", "ItemCount",
			"IsOpen", "OpenTime", "CreateTime", "HistoryDeleteTime", "IsCash"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
