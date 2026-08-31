using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class FieldMonsterBuffTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvRmllbGRUYWJsZV9fX+2VhOuTnC9GaWVsZE1vbnN0ZXJC" + "dWZmVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i0AEKFUZpZWxk" + "TW9uc3RlckJ1ZmZUYWJsZRIbChNhbGVydERldGVjdGlvbkFuZ2xlGAEgASgB" + "Eh4KFmFsZXJ0RGV0ZWN0aW9uRGlzdGFuY2UYAiABKAESEAoIYnVmZlRJbWUY" + "AyABKAESGwoTZGV0ZWN0aW9uSWdub3JlV2FsbBgEIAEoBRIVCg1kZXRlY3Rp" + "b25UeXBlGAUgAygFEhUKDWRpc3RhbmNlQ2hhc2UYBiABKAESCgoCaWQYByAB" + "KAUSEQoJbW92ZVNwZWVkGAggASgBQkRCE1Byb3RvLkRlc2lnbi5jb21tb25Q" + "AVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1v" + "bmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMonsterBuffTable), FieldMonsterBuffTable.Parser, new string[8] { "AlertDetectionAngle", "AlertDetectionDistance", "BuffTIme", "DetectionIgnoreWall", "DetectionType", "DistanceChase", "Id", "MoveSpeed" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
