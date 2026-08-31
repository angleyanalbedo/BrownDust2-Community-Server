using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarBattleStartResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9Ub3RhbFdhckJhdHRsZVN0YXJ0UmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldBoeQ29tbW9ucy9CYXR0bGVDaGFyREJJbmZvLnByb3RvGiVD" + "b21tb25zL1BpY3RvcmlhbEJ1ZmZTdGF0REJJbmZvLnByb3RvGiFDb21tb25z" + "L0V2ZW50U2NoZWR1bGVEQkluZm8ucHJvdG8imwIKG1RvdGFsV2FyQmF0dGxl" + "U3RhcnRSZXNwb25zZRIaChJiYXR0bGVfcmFuZG9tX3NlZWQYASABKAUSMwoO" + "Ymx1ZV9jaGFyX2luZm8YAiADKAsyGy5wcm90by5uZXQuQmF0dGxlQ2hhckRC" + "SW5mbxIyCg1yZWRfY2hhcl9pbmZvGAMgAygLMhsucHJvdG8ubmV0LkJhdHRs" + "ZUNoYXJEQkluZm8SOgoOYnVmZl9zdGF0X2luZm8YBCADKAsyIi5wcm90by5u" + "ZXQuUGljdG9yaWFsQnVmZlN0YXREQkluZm8SOwoTZXZlbnRfc2NoZWR1bGVf" + "aW5mbxgFIAEoCzIeLnByb3RvLm5ldC5FdmVudFNjaGVkdWxlREJJbmZvYgZw" + "cm90bzM="), new FileDescriptor[3]
	{
		BattleCharDBInfoReflection.Descriptor,
		PictorialBuffStatDBInfoReflection.Descriptor,
		EventScheduleDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarBattleStartResponse), TotalWarBattleStartResponse.Parser, new string[5] { "BattleRandomSeed", "BlueCharInfo", "RedCharInfo", "BuffStatInfo", "EventScheduleInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
