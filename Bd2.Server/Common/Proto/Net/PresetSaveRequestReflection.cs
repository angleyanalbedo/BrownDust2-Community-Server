using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PresetSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L1ByZXNldFNhdmVSZXF1ZXN0LnByb3RvEglwcm90by5uZXQaGkNvbW1vbnMvUHJlc2V0REJJbmZvLnByb3RvIk4KEVByZXNldFNhdmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRIsCgtwcmVzZXRfaW5mbxgCIAEoCzIXLnByb3RvLm5ldC5QcmVzZXREQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { PresetDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PresetSaveRequest), PresetSaveRequest.Parser, new string[2] { "Seq", "PresetInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
