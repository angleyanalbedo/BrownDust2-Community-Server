using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class FieldMonsterMoveTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjljb21tb24uZGIvRmllbGRUYWJsZV9fX+2VhOuTnC9GaWVsZE1vbnN0ZXJN" + "b3ZlVGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i2QMKFUZpZWxk" + "TW9uc3Rlck1vdmVUYWJsZRIWCg5kZXRlY3Rpb25BbmdsZRgBIAEoARIZChFk" + "ZXRlY3Rpb25EaXN0YW5jZRgCIAEoARIbChNkZXRlY3Rpb25JZ25vcmVXYWxs" + "GAMgASgFEhUKDWRldGVjdGlvblR5cGUYBCADKAUSFQoNZGlzdGFuY2VDaGFz" + "ZRgFIAEoARIXCg9kaXN0YW5jZURlZmF1bHQYBiABKAESEwoLZGlzdGFuY2VS" + "dW4YByABKAESFgoOZW5jb3VudGVyQW5nbGUYCCABKAESGQoRZW5jb3VudGVy" + "RGlzdGFuY2UYCSABKAESCgoCaWQYCiABKAUSFQoNbGFzdHRpbWVDaGFzZRgL" + "IAEoARIKCgJsdhgMIAEoBRIWCg5tb3ZlSWdub3JlV2FsbBgNIAEoBRIOCgZt" + "b3ZpbmcYDiABKAUSEgoKc3BlZWRDaGFzZRgPIAEoARIUCgxzcGVlZERlZmF1" + "bHQYECABKAESEAoIc3BlZWRSdW4YESABKAESEQoJdGltZUNoYXNlGBIgASgB" + "EhMKC3RpbWVEZWZhdWx0GBMgASgBEhUKDXRpbWVEaXNjb3ZlcnkYFCABKAES" + "DwoHdGltZVJ1bhgVIAEoAUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4v" + "UHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMonsterMoveTable), FieldMonsterMoveTable.Parser, new string[21]
		{
			"DetectionAngle", "DetectionDistance", "DetectionIgnoreWall", "DetectionType", "DistanceChase", "DistanceDefault", "DistanceRun", "EncounterAngle", "EncounterDistance", "Id",
			"LasttimeChase", "Lv", "MoveIgnoreWall", "Moving", "SpeedChase", "SpeedDefault", "SpeedRun", "TimeChase", "TimeDefault", "TimeDiscovery",
			"TimeRun"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
