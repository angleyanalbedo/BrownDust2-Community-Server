using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleUserBaseInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL1B2cEJhdHRsZVVzZXJCYXNlSW5mby5wcm90bxIJcHJvdG8ubmV0IlgKFVB2cEJhdHRsZVVzZXJCYXNlSW5mbxIKCgJ2cBgBIAEoBRIMCgRyYW5rGAIgASgFEhEKCXdpbl9jb3VudBgDIAEoBRISCgpsb3NlX2NvdW50GAQgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleUserBaseInfo), PvpBattleUserBaseInfo.Parser, new string[4] { "Vp", "Rank", "WinCount", "LoseCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
