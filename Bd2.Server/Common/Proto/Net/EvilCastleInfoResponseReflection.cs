using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9FdmlsQ2FzdGxlSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90" + "by5uZXQaHkNvbW1vbnMvRXZpbENhc3RsZURCSW5mby5wcm90bxojQ29tbW9u" + "cy9FdmlsQ2FzdGxlVG90YWxEQkluZm8ucHJvdG8iuQEKFkV2aWxDYXN0bGVJ" + "bmZvUmVzcG9uc2USNQoQZXZpbF9jYXN0bGVfaW5mbxgBIAMoCzIbLnByb3Rv" + "Lm5ldC5FdmlsQ2FzdGxlREJJbmZvEkAKFmV2aWxfY2FzdGxlX3RvdGFsX2lu" + "Zm8YAiABKAsyIC5wcm90by5uZXQuRXZpbENhc3RsZVRvdGFsREJJbmZvEg4K" + "BnNlYXNvbhgDIAEoBRIWCg5yZWd1bGFyX3NlYXNvbhgEIAEoBWIGcHJvdG8z"), new FileDescriptor[2]
	{
		EvilCastleDBInfoReflection.Descriptor,
		EvilCastleTotalDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleInfoResponse), EvilCastleInfoResponse.Parser, new string[4] { "EvilCastleInfo", "EvilCastleTotalInfo", "Season", "RegularSeason" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
