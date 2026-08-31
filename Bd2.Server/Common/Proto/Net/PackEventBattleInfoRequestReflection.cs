using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackEventBattleInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXF1ZXN0L1BhY2tFdmVudEJhdHRsZUluZm9SZXF1ZXN0LnByb3RvEglwcm90by5uZXQiPAoaUGFja0V2ZW50QmF0dGxlSW5mb1JlcXVlc3QSCwoDc2VxGAEgASgFEhEKCWV2ZW50X3VpZBgCIAMoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventBattleInfoRequest), PackEventBattleInfoRequest.Parser, new string[2] { "Seq", "EventUid" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
