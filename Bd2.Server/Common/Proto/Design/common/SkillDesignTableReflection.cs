using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SkillDesignTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj9jb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL1Nr" + "aWxsRGVzaWduVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24ioAIK" + "EFNraWxsRGVzaWduVGFibGUSHwoXYXR0YWNrRWZmZWN0U2tpbGxUZXh0SWQY" + "ASADKAUSFwoPY2FtZXJhU2hha2VUeXBlGAIgASgFEhgKEGNhbWVyYVpvb21J" + "blR5cGUYAyABKAUSCgoCaWQYBCABKAUSHwoXc2tpbGwxRWZmZWN0U2tpbGxU" + "ZXh0SWQYBSADKAUSHwoXc2tpbGwyRWZmZWN0U2tpbGxUZXh0SWQYBiADKAUS" + "FwoPc2tpbGxCYWNrZ3JvdW5kGAcgASgJEhUKDXNraWxsQ3V0U2NlbmUYCCAB" + "KAkSGwoTc2tpbGxJY29uU3ByaXRlTmFtZRgJIAEoCRIdChVzdHVuRWZmZWN0" + "U2tpbGxUZXh0SWQYCiADKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUu" + "L1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkillDesignTable), SkillDesignTable.Parser, new string[10] { "AttackEffectSkillTextId", "CameraShakeType", "CameraZoomInType", "Id", "Skill1EffectSkillTextId", "Skill2EffectSkillTextId", "SkillBackground", "SkillCutScene", "SkillIconSpriteName", "StunEffectSkillTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
