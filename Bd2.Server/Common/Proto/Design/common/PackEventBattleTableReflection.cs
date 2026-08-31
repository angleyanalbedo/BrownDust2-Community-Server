using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class PackEventBattleTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjpjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L1BhY2tFdmVudEJh" + "dHRsZVRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIvUBChRQYWNr" + "RXZlbnRCYXR0bGVUYWJsZRIUCgxiYXR0bGVEZWNrSWQYASABKAUSEwoLYmF0" + "dGxlUG93ZXIYAiABKAUSFAoMZXZlbnRBcENvdW50GAMgASgFEg8KB2dyb3Vw" + "SWQYBCABKAUSCgoCaWQYBSABKAUSFQoNaXNGaXhlZENhbWVyYRgGIAEoBRIb" + "ChNxdWlja0JhdHRsZVBvc3NpYmxlGAcgASgFEhkKEXJlcGVhdFJld2FyZENv" + "dW50GAggAygFEhgKEHJlcGVhdFJld2FyZFR5cGUYCSADKAUSFgoOcmVwZWF0" + "UmV3YXJkaWQYCiADKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1By" + "b3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventBattleTable), PackEventBattleTable.Parser, new string[10] { "BattleDeckId", "BattlePower", "EventApCount", "GroupId", "Id", "IsFixedCamera", "QuickBattlePossible", "RepeatRewardCount", "RepeatRewardType", "RepeatRewardid" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
