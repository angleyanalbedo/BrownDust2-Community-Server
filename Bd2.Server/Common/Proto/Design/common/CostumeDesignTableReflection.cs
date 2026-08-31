using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CostumeDesignTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkFjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0Nv" + "c3R1bWVEZXNpZ25UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKN" + "AwoSQ29zdHVtZURlc2lnblRhYmxlEh8KF2F0dGFja0VmZmVjdFNraWxsVGV4" + "dElkGAEgAygFEhUKDWJsdXJJbWFnZU5hbWUYAiABKAkSFAoMZmFjZUljb25O" + "YW1lGAMgASgJEhYKDmZhY2VJbGx1c3ROYW1lGAQgASgJEhYKDmljb25TcHJp" + "dGVOYW1lGAUgASgJEgoKAmlkGAYgASgFEhIKCmlsbHVzdE5hbWUYByABKAkS" + "GwoTaW52ZW50b3J5SWxsdXN0TmFtZRgIIAEoCRIRCglpc0NvbGxhYm8YCSAB" + "KAUSFQoNbG9iYnlDdXRzY2VuZRgKIAEoCRIWCg5sb29wUHJlZmFiTmFtZRgL" + "IAEoCRISCgpwcmVmYWJOYW1lGAwgASgJEhgKEHNpbXBsZUlsbHVzdE5hbWUY" + "DSABKAkSGQoRc2tpbGxUaW1lbGluZU5hbWUYDiABKAkSFgoOdWlSZXNvdXJj" + "ZU5hbWUYDyABKAkSGQoRdm9pY2VSZXNvdXJjZU5hbWUYECABKAlCREITUHJv" + "dG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQ" + "cm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeDesignTable), CostumeDesignTable.Parser, new string[16]
		{
			"AttackEffectSkillTextId", "BlurImageName", "FaceIconName", "FaceIllustName", "IconSpriteName", "Id", "IllustName", "InventoryIllustName", "IsCollabo", "LobbyCutscene",
			"LoopPrefabName", "PrefabName", "SimpleIllustName", "SkillTimelineName", "UiResourceName", "VoiceResourceName"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
