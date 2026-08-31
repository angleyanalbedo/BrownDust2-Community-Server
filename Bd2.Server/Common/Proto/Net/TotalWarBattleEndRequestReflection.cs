using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarBattleEndRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L1RvdGFsV2FyQmF0dGxlRW5kUmVxdWVzdC5wcm90bxIJcHJv" + "dG8ubmV0GiBDb21tb25zL0JhdHRsZURhbWFnZURCSW5mby5wcm90byJaChhU" + "b3RhbFdhckJhdHRsZUVuZFJlcXVlc3QSCwoDc2VxGAEgASgFEjEKCnNjb3Jl" + "X2luZm8YAiADKAsyHS5wcm90by5uZXQuQmF0dGxlRGFtYWdlREJJbmZvYgZw" + "cm90bzM="), new FileDescriptor[1] { BattleDamageDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarBattleEndRequest), TotalWarBattleEndRequest.Parser, new string[2] { "Seq", "ScoreInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
