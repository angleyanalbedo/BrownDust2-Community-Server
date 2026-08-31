using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntRankInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L01vbnN0ZXJIdW50UmFua0luZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiOQoaTW9uc3Rlckh1bnRSYW5rSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFEg4KBnNlYXNvbhgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntRankInfoRequest), MonsterHuntRankInfoRequest.Parser, new string[2] { "Seq", "Season" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
