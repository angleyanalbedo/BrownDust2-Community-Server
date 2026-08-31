using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PresetInfoChangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L1ByZXNldEluZm9DaGFuZ2VSZXF1ZXN0LnByb3RvEglwcm90" + "by5uZXQihAEKF1ByZXNldEluZm9DaGFuZ2VSZXF1ZXN0EgsKA3NlcRgBIAEo" + "BRITCgtwcmVzZXRfbmFtZRgCIAEoCRIaChJwcmVzZXRfcmVzb3VyY2VfaWQY" + "AyABKAUSHQoVcHJlc2V0X3Jlc291cmNlX2NvbG9yGAQgASgFEgwKBHNsb3QY" + "BSABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PresetInfoChangeRequest), PresetInfoChangeRequest.Parser, new string[5] { "Seq", "PresetName", "PresetResourceId", "PresetResourceColor", "Slot" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
