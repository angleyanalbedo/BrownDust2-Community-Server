using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackEventBattleInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9QYWNrRXZlbnRCYXR0bGVJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBojQ29tbW9ucy9QYWNrRXZlbnRCYXR0bGVEQkluZm8ucHJvdG8iTQobUGFja0V2ZW50QmF0dGxlSW5mb1Jlc3BvbnNlEi4KBGluZm8YASADKAsyIC5wcm90by5uZXQuUGFja0V2ZW50QmF0dGxlREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { PackEventBattleDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventBattleInfoResponse), PackEventBattleInfoResponse.Parser, new string[1] { "Info" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
