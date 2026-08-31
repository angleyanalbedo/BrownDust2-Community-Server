using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarDeckPresetSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitSZXF1ZXN0L1RvdGFsV2FyRGVja1ByZXNldFNhdmVSZXF1ZXN0LnByb3Rv" + "Eglwcm90by5uZXQaJkNvbW1vbnMvVG90YWxXYXJEZWNrUHJlc2V0REJJbmZv" + "LnByb3RvImYKHVRvdGFsV2FyRGVja1ByZXNldFNhdmVSZXF1ZXN0EgsKA3Nl" + "cRgBIAEoBRI4CgtwcmVzZXRfaW5mbxgCIAEoCzIjLnByb3RvLm5ldC5Ub3Rh" + "bFdhckRlY2tQcmVzZXREQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { TotalWarDeckPresetDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarDeckPresetSaveRequest), TotalWarDeckPresetSaveRequest.Parser, new string[2] { "Seq", "PresetInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
