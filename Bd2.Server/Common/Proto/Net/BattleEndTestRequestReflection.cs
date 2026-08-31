using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleEndTestRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L0JhdHRsZUVuZFRlc3RSZXF1ZXN0LnByb3RvEglwcm90by5u" + "ZXQaGENvbW1vbnMvQ2hhckRCSW5mby5wcm90byLDAQoUQmF0dGxlRW5kVGVz" + "dFJlcXVlc3QSCwoDc2VxGAEgASgFEhUKDWJhdHRsZV9yZXN1bHQYAiABKAUS" + "KAoJY2hhcl9pbmZvGAMgAygLMhUucHJvdG8ubmV0LkNoYXJEQkluZm8SDwoH" + "cGFja19pZBgEIAEoBRIVCg1hY2hpZXZlX2luZGV4GAUgAygFEhcKD2VuZF9p" + "bnZlbl9pbmRleBgGIAMoAxIcChRpc19tb25zdGVyX2h1bnRfbmV4dBgHIAEo" + "CGIGcHJvdG8z"), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleEndTestRequest), BattleEndTestRequest.Parser, new string[7] { "Seq", "BattleResult", "CharInfo", "PackId", "AchieveIndex", "EndInvenIndex", "IsMonsterHuntNext" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
