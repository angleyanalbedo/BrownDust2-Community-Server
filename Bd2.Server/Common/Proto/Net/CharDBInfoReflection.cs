using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb21tb25zL0NoYXJEQkluZm8ucHJvdG8SCXByb3RvLm5ldBohQ29tbW9u" + "cy9QaWN0b3JpYWxCb29rREJJbmZvLnByb3RvIrcCCgpDaGFyREJJbmZvEhMK" + "C2ludmVuX2luZGV4GAEgASgDEgoKAmlkGAIgASgFEgoKAmhwGAMgASgDEg0K" + "BWxldmVsGAQgASgFEhIKCmNvc3R1bWVfaWQYBSABKAUSCwoDZXhwGAYgASgF" + "EhMKC3VzZV9jb3N0dW1lGAcgASgDEhQKDHRhbGVudF9sZXZlbBgIIAEoBRIS" + "Cgp0YWxlbnRfZXhwGAkgASgFEhkKEXNvbGlkYXJpdHlfcmV3YXJkGAogASgF" + "EhMKC2V4cGlyeV90aW1lGAsgASgDEjoKEnBpY3RvcmlhbGJvb2tfaW5mbxgM" + "IAMoCzIeLnByb3RvLm5ldC5QaWN0b3JpYWxCb29rREJJbmZvEiEKGWNvbm5l" + "Y3RfcG90ZW50aWFsX2Nvc3R1bWUYDSABKAViBnByb3RvMw=="), new FileDescriptor[1] { PictorialBookDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharDBInfo), CharDBInfo.Parser, new string[13]
		{
			"InvenIndex", "Id", "Hp", "Level", "CostumeId", "Exp", "UseCostume", "TalentLevel", "TalentExp", "SolidarityReward",
			"ExpiryTime", "PictorialbookInfo", "ConnectPotentialCostume"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
