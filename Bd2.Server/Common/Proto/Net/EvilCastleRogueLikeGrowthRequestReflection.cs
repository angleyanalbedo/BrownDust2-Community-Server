using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EvilCastleRogueLikeGrowthRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXF1ZXN0L0V2aWxDYXN0bGVSb2d1ZUxpa2VHcm93dGhSZXF1ZXN0LnBy" + "b3RvEglwcm90by5uZXQaLUNvbW1vbnMvRXZpbENhc3RsZVJvZ3VlTGlrZUdy" + "b3d0aERCSW5mby5wcm90byJwCiBFdmlsQ2FzdGxlUm9ndWVMaWtlR3Jvd3Ro" + "UmVxdWVzdBILCgNzZXEYASABKAUSPwoLZ3Jvd3RoX2luZm8YAiABKAsyKi5w" + "cm90by5uZXQuRXZpbENhc3RsZVJvZ3VlTGlrZUdyb3d0aERCSW5mb2IGcHJv" + "dG8z"), new FileDescriptor[1] { EvilCastleRogueLikeGrowthDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EvilCastleRogueLikeGrowthRequest), EvilCastleRogueLikeGrowthRequest.Parser, new string[2] { "Seq", "GrowthInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
