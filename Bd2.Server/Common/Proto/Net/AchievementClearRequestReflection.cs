using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AchievementClearRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXF1ZXN0L0FjaGlldmVtZW50Q2xlYXJSZXF1ZXN0LnByb3RvEglwcm90" + "by5uZXQaIkNvbW1vbnMvQWNoaWV2ZW1lbnRDbGVhckluZm8ucHJvdG8icwoX" + "QWNoaWV2ZW1lbnRDbGVhclJlcXVlc3QSCwoDc2VxGAEgASgFEhYKDmNvbnRl" + "bnRzX2dyb3VwGAIgASgFEjMKCmNsZWFyX2luZm8YAyADKAsyHy5wcm90by5u" + "ZXQuQWNoaWV2ZW1lbnRDbGVhckluZm9iBnByb3RvMw=="), new FileDescriptor[1] { AchievementClearInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AchievementClearRequest), AchievementClearRequest.Parser, new string[3] { "Seq", "ContentsGroup", "ClearInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
