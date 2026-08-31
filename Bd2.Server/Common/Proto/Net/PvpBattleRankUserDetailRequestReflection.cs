using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleRankUserDetailRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXF1ZXN0L1B2cEJhdHRsZVJhbmtVc2VyRGV0YWlsUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkkKHlB2cEJhdHRsZVJhbmtVc2VyRGV0YWlsUmVxdWVzdBILCgNzZXEYASABKAUSGgoSdGFyZ2V0X293bmVyX2luZGV4GAIgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleRankUserDetailRequest), PvpBattleRankUserDetailRequest.Parser, new string[2] { "Seq", "TargetOwnerIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
