using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class BuffTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0J1" + "ZmZUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiL0AwoJQnVmZlRh" + "YmxlEhEKCUFkZEJ1ZmZJZBgBIAEoBRIVCg1idWZmQXBwbHlUeXBlGAIgASgF" + "EhcKD2J1ZmZDb25kaXRpb25JZBgDIAEoBRIVCg1idWZmQ291bnRUeXBlGAQg" + "ASgFEhsKE2J1ZmZEZXNjU2tpbGxUZXh0SWQYBSABKAUSFwoPYnVmZkRpc3Bs" + "YXlUeXBlGAYgASgFEhgKEGJ1ZmZEaXNwbGF5VmFsdWUYByABKAUSEQoJYnVm" + "Zkdyb3VwGAggASgFEhoKEmJ1ZmZJY29uU3ByaXRlTmFtZRgJIAEoCRIXCg9i" + "dWZmU2tpbGxUZXh0SWQYCiABKAUSEAoIYnVmZlR1cm4YCyABKAUSEAoIYnVm" + "ZlR5cGUYDCABKAUSEQoJYnVmZlZhbHVlGA0gASgBEhEKCWNsYXNzVHlwZRgO" + "IAEoCRIaChJjb25kaXRpb25BZGRCdWZmSWQYDyABKAUSGAoQZWZmZWN0UHJl" + "ZmFiTmFtZRgQIAEoCRIKCgJpZBgRIAEoBRISCgptYWdpY1ZhbHVlGBIgASgB" + "EhEKCW93bmVyVHlwZRgTIAEoBRIfChdzcGVjaWFsRWZmZWN0UHJlZmFiTmFt" + "ZRgUIAEoCRIQCghzdGF0VHlwZRgVIAEoBRIPCgdzdWJUeXBlGBYgASgFQkRC" + "E1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9u" + "qgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BuffTable), BuffTable.Parser, new string[22]
		{
			"AddBuffId", "BuffApplyType", "BuffConditionId", "BuffCountType", "BuffDescSkillTextId", "BuffDisplayType", "BuffDisplayValue", "BuffGroup", "BuffIconSpriteName", "BuffSkillTextId",
			"BuffTurn", "BuffType", "BuffValue", "ClassType", "ConditionAddBuffId", "EffectPrefabName", "Id", "MagicValue", "OwnerType", "SpecialEffectPrefabName",
			"StatType", "SubType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
