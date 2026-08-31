using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarDeckPresetInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXNwb25zZS9Ub3RhbFdhckRlY2tQcmVzZXRJbmZvUmVzcG9uc2UucHJv" + "dG8SCXByb3RvLm5ldBomQ29tbW9ucy9Ub3RhbFdhckRlY2tQcmVzZXREQklu" + "Zm8ucHJvdG8iWgoeVG90YWxXYXJEZWNrUHJlc2V0SW5mb1Jlc3BvbnNlEjgK" + "C3ByZXNldF9pbmZvGAEgAygLMiMucHJvdG8ubmV0LlRvdGFsV2FyRGVja1By" + "ZXNldERCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { TotalWarDeckPresetDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarDeckPresetInfoResponse), TotalWarDeckPresetInfoResponse.Parser, new string[1] { "PresetInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
