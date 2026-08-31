using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntScheduleInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXNwb25zZS9Nb25zdGVySHVudFNjaGVkdWxlSW5mb1Jlc3BvbnNlLnBy" + "b3RvEglwcm90by5uZXQaGUNvbW1vbnMvU2NoZHVsZUluZm8ucHJvdG8ixgEK" + "H01vbnN0ZXJIdW50U2NoZWR1bGVJbmZvUmVzcG9uc2USRgoabW9uc3Rlcl9o" + "dW50X3NjaGVkdWxlX2luZm8YASABKAsyIi5wcm90by5uZXQuTW9uc3Rlckh1" + "bnRTY2hlZHVsZUluZm8SHAoUc3RhcnRfcmVndWxhcl9zZWFzb24YAiABKAUS" + "PQoOc2Vhc29uX2hpc3RvcnkYAyADKAsyJS5wcm90by5uZXQuTW9uc3Rlckh1" + "bnRTY2hlZHVsZUhpc3RvcnliBnByb3RvMw=="), new FileDescriptor[1] { SchduleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntScheduleInfoResponse), MonsterHuntScheduleInfoResponse.Parser, new string[3] { "MonsterHuntScheduleInfo", "StartRegularSeason", "SeasonHistory" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
