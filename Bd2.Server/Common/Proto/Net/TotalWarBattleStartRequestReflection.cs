using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarBattleStartRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L1RvdGFsV2FyQmF0dGxlU3RhcnRSZXF1ZXN0LnByb3RvEglw" + "cm90by5uZXQaHkNvbW1vbnMvQmF0dGxlQ2hhckRCSW5mby5wcm90byKoAQoa" + "VG90YWxXYXJCYXR0bGVTdGFydFJlcXVlc3QSCwoDc2VxGAEgASgFEhQKDGJh" + "dHRsZV9pbmRleBgCIAEoBRIzCg5ibHVlX2NoYXJfaW5mbxgDIAMoCzIbLnBy" + "b3RvLm5ldC5CYXR0bGVDaGFyREJJbmZvEjIKDXJlZF9jaGFyX2luZm8YBCAD" + "KAsyGy5wcm90by5uZXQuQmF0dGxlQ2hhckRCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { BattleCharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarBattleStartRequest), TotalWarBattleStartRequest.Parser, new string[4] { "Seq", "BattleIndex", "BlueCharInfo", "RedCharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
