using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CostumeNodeTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj9jb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0Nv" + "c3R1bWVOb2RlVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24iswYK" + "EENvc3R1bWVOb2RlVGFibGUSFwoPYWN0aXZlSXRlbUNvdW50GAEgAygFEhQK" + "DGFjdGl2ZUl0ZW1JZBgCIAMoBRIWCg5hY3RpdmVJdGVtVHlwZRgDIAMoBRIR" + "CglhZGRCdWZmSWQYBCABKAUSIwobYWRkQnVmZk1vZGlmeUJ1ZmZNYWdpY1Zh" + "bHVlGAUgASgBEh4KFmFkZEJ1ZmZNb2RpZnlCdWZmT3JkZXIYBiABKAUSHQoV" + "YWRkQnVmZk1vZGlmeUJ1ZmZUdXJuGAcgASgFEh4KFmFkZEJ1ZmZNb2RpZnlC" + "dWZmVmFsdWUYCCABKAESFAoMYWRkQnVmZk9yZGVyGAkgASgFEhgKEGFkZEJ1" + "ZmZUZXh0T3JkZXIYCiABKAUSEwoLYXR0YWNrUmFuZ2UYCyABKAUSGAoQYXR0" + "YWNrUmFuZ2VDb3VudBgMIAEoBRIsCiRjb25kaXRpb25BZGRCdWZmTW9kaWZ5" + "QnVmZk1hZ2ljVmFsdWUYDSABKAESJwofY29uZGl0aW9uQWRkQnVmZk1vZGlm" + "eUJ1ZmZPcmRlchgOIAEoBRImCh5jb25kaXRpb25BZGRCdWZmTW9kaWZ5QnVm" + "ZlR1cm4YDyABKAUSJwofY29uZGl0aW9uQWRkQnVmZk1vZGlmeUJ1ZmZWYWx1" + "ZRgQIAEoARIWCg5jb25kaXRpb25HcmFkZRgRIAEoBRIXCg9jb25kaXRpb25O" + "b2RlSWQYEiADKAUSHQoVY29vbGRvd25EZWNyZWFzZVZhbHVlGBMgASgFEg8K" + "B2dyb3VwSWQYFCABKAUSCgoCaWQYFSABKAUSHAoUbW9kaWZ5QnVmZk1hZ2lj" + "VmFsdWUYFiABKAESFwoPbW9kaWZ5QnVmZk9yZGVyGBcgASgFEhYKDm1vZGlm" + "eUJ1ZmZUdXJuGBggASgFEhcKD21vZGlmeUJ1ZmZWYWx1ZRgZIAEoARIVCg1u" + "b2RlR3JvdXBUeXBlGBogASgFEhAKCG5vZGVUeXBlGBsgASgFEhcKD3NwRGVj" + "cmVhc2VWYWx1ZRgcIAEoBRIQCghzdGF0VHlwZRgdIAEoBRIRCglzdGF0VmFs" + "dWUYHiABKAFCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRl" + "c2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeNodeTable), CostumeNodeTable.Parser, new string[30]
		{
			"ActiveItemCount", "ActiveItemId", "ActiveItemType", "AddBuffId", "AddBuffModifyBuffMagicValue", "AddBuffModifyBuffOrder", "AddBuffModifyBuffTurn", "AddBuffModifyBuffValue", "AddBuffOrder", "AddBuffTextOrder",
			"AttackRange", "AttackRangeCount", "ConditionAddBuffModifyBuffMagicValue", "ConditionAddBuffModifyBuffOrder", "ConditionAddBuffModifyBuffTurn", "ConditionAddBuffModifyBuffValue", "ConditionGrade", "ConditionNodeId", "CooldownDecreaseValue", "GroupId",
			"Id", "ModifyBuffMagicValue", "ModifyBuffOrder", "ModifyBuffTurn", "ModifyBuffValue", "NodeGroupType", "NodeType", "SpDecreaseValue", "StatType", "StatValue"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
