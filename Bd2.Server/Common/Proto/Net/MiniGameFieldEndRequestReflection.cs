using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldEndRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L01pbmlHYW1lRmllbGRFbmRSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiPAoXTWluaUdhbWVGaWVsZEVuZFJlcXVlc3QSCwoDc2VxGAEgASgFEhQKDGlzX2ZvcmNlX2VuZBgCIAEoCGIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldEndRequest), MiniGameFieldEndRequest.Parser, new string[2] { "Seq", "IsForceEnd" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
