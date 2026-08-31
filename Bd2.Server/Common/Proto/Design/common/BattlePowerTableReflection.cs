using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class BattlePowerTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvQmF0dGxlVGFibGVfX1/soITtiKwvQmF0dGxlUG93ZXJU" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLRAQoQQmF0dGxlUG93" + "ZXJUYWJsZRIZChFjb3N0dW1lR3JhZGVQb3dlchgBIAEoBRIUCgxjb3N0dW1l" + "UG93ZXIYAiABKAUSCgoCaWQYAyABKAUSFwoPbGV2ZWxWYWx1ZVBvd2VyGAQg" + "ASgFEiQKHHBvdGVudGlhbENvbm5lY3Rpb25Ob2RlUG93ZXIYBSABKAUSIAoY" + "cG90ZW50aWFsUHVibGljTm9kZVBvd2VyGAYgASgFEh8KF3BvdGVudGlhbFNr" + "aWxsTm9kZVBvd2VyGAcgASgFQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoV" + "Li9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattlePowerTable), BattlePowerTable.Parser, new string[7] { "CostumeGradePower", "CostumePower", "Id", "LevelValuePower", "PotentialConnectionNodePower", "PotentialPublicNodePower", "PotentialSkillNodePower" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
