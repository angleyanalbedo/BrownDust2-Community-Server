using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarDeckPresetDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZDb21tb25zL1RvdGFsV2FyRGVja1ByZXNldERCSW5mby5wcm90bxIJcHJv" + "dG8ubmV0GiBDb21tb25zL1RvdGFsV2FyRGVja0RCSW5mby5wcm90byJvChhU" + "b3RhbFdhckRlY2tQcmVzZXREQkluZm8SDAoEc2xvdBgBIAEoBRITCgtwcmVz" + "ZXRfbmFtZRgCIAEoCRIwCglkZWNrX2luZm8YAyADKAsyHS5wcm90by5uZXQu" + "VG90YWxXYXJEZWNrREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { TotalWarDeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarDeckPresetDBInfo), TotalWarDeckPresetDBInfo.Parser, new string[3] { "Slot", "PresetName", "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
