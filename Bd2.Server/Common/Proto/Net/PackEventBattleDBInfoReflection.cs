using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackEventBattleDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL1BhY2tFdmVudEJhdHRsZURCSW5mby5wcm90bxIJcHJvdG8ubmV0ImgKFVBhY2tFdmVudEJhdHRsZURCSW5mbxIRCglldmVudF91aWQYASABKAUSEAoIZ3JvdXBfaWQYAiABKAUSCgoCaWQYAyABKAUSHgoWYmF0dGxlX2NoYWxsZW5nZV9pbmRleBgEIAMoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventBattleDBInfo), PackEventBattleDBInfo.Parser, new string[4] { "EventUid", "GroupId", "Id", "BattleChallengeIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
