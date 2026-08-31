using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldDeckSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L0ZpZWxkRGVja1NhdmVSZXF1ZXN0LnByb3RvEglwcm90by5uZXQaHUNvbW1vbnMvRmllbGREZWNrREJJbmZvLnByb3RvIlgKFEZpZWxkRGVja1NhdmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRIzCg9maWVsZF9kZWNrX2luZm8YAiADKAsyGi5wcm90by5uZXQuRmllbGREZWNrREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { FieldDeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldDeckSaveRequest), FieldDeckSaveRequest.Parser, new string[2] { "Seq", "FieldDeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
