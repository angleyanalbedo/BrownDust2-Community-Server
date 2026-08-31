using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PvpBattleEndRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L1B2cEJhdHRsZUVuZFJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJSChNQdnBCYXR0bGVFbmRSZXF1ZXN0EgsKA3NlcRgBIAEoBRIVCg1iYXR0bGVfcmVzdWx0GAIgASgFEhcKD2VuZF9pbnZlbl9pbmRleBgDIAMoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PvpBattleEndRequest), PvpBattleEndRequest.Parser, new string[3] { "Seq", "BattleResult", "EndInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
