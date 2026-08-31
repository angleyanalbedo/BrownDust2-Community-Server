using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class TalentTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjZjb21tb24uZGIvVGFsZW50VGFibGVfX1/snqzriqXsiqTtgqwvVGFsZW50" + "VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ikgIKC1RhbGVudFRh" + "YmxlEhUKDWJsdXJJbWFnZU5hbWUYASABKAkSFQoNZ3Jvd3RoR3JvdXBJZBgC" + "IAEoBRIWCg5pY29uU3ByaXRlTmFtZRgDIAEoCRIKCgJpZBgEIAEoBRIXCg9p" + "bWFnZVNwcml0ZU5hbWUYBSABKAkSEAoIbWF4TGV2ZWwYBiABKAUSGAoQc2tp" + "bGxFZmZlY3RUYWxrMRgHIAEoBRIYChBza2lsbEVmZmVjdFRhbGsyGAggASgF" + "EhwKFHRhbGVudERlc2NOYW1lVGV4dElkGAkgASgFEhgKEHRhbGVudE5hbWVU" + "ZXh0SWQYCiABKAUSGgoSdGFsZW50U2tpbGxHcm91cElkGAsgASgFQkRCE1By" + "b3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgIT" + "UHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentTable), TalentTable.Parser, new string[11]
		{
			"BlurImageName", "GrowthGroupId", "IconSpriteName", "Id", "ImageSpriteName", "MaxLevel", "SkillEffectTalk1", "SkillEffectTalk2", "TalentDescNameTextId", "TalentNameTextId",
			"TalentSkillGroupId"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
