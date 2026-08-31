using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PresetAddSlotRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L1ByZXNldEFkZFNsb3RSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiNgoUUHJlc2V0QWRkU2xvdFJlcXVlc3QSCwoDc2VxGAEgASgFEhEKCWFkZF9jb3VudBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PresetAddSlotRequest), PresetAddSlotRequest.Parser, new string[2] { "Seq", "AddCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
