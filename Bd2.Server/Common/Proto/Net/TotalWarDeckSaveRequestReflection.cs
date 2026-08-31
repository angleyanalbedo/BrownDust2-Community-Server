using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TotalWarDeckSaveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L1RvdGFsV2FyRGVja1NhdmVSZXF1ZXN0LnByb3RvEglwcm90" + "by5uZXQaIENvbW1vbnMvVG90YWxXYXJEZWNrREJJbmZvLnByb3RvIlgKF1Rv" + "dGFsV2FyRGVja1NhdmVSZXF1ZXN0EgsKA3NlcRgBIAEoBRIwCglkZWNrX2lu" + "Zm8YAiADKAsyHS5wcm90by5uZXQuVG90YWxXYXJEZWNrREJJbmZvYgZwcm90" + "bzM="), new FileDescriptor[1] { TotalWarDeckDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TotalWarDeckSaveRequest), TotalWarDeckSaveRequest.Parser, new string[2] { "Seq", "DeckInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
