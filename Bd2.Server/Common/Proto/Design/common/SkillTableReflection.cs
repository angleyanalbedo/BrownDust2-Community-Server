using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class SkillTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL1Nr" + "aWxsVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i/QIKClNraWxs" + "VGFibGUSFgoOYXR0YWNrTW92ZVR5cGUYASABKAUSEwoLYXR0YWNrUmFuZ2UY" + "AiABKAUSGAoQYXR0YWNrUmFuZ2VDb3VudBgDIAEoBRISCgphdHRhY2tUeXBl" + "GAQgASgFEg4KBmJ1ZmZJZBgFIAMoBRIQCghjb29sZG93bhgGIAEoBRIPCgdn" + "cm91cElkGAcgASgFEgoKAmlkGAggASgFEhYKDm1haW5UYXJnZXRUeXBlGAkg" + "ASgFEhcKD21haW5UYXJnZXRWYWx1ZRgKIAEoBRITCgtyZXBlYXRDb3VudBgL" + "IAEoBRIcChRza2lsbERlc2NTa2lsbFRleHRJZBgMIAEoBRIVCg1za2lsbERl" + "c2lnbklkGA0gASgFEhwKFHNraWxsTmFtZVNraWxsVGV4dElkGA4gASgFEhQK" + "DHNraWxsVXNlUmF0ZRgPIAEoARISCgpzcFJlcUNvdW50GBAgASgFEhIKCnRh" + "cmdldFR5cGUYESABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1By" + "b3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SkillTable), SkillTable.Parser, new string[17]
		{
			"AttackMoveType", "AttackRange", "AttackRangeCount", "AttackType", "BuffId", "Cooldown", "GroupId", "Id", "MainTargetType", "MainTargetValue",
			"RepeatCount", "SkillDescSkillTextId", "SkillDesignId", "SkillNameSkillTextId", "SkillUseRate", "SpReqCount", "TargetType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
