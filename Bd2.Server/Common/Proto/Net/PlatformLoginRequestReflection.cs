using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PlatformLoginRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L1BsYXRmb3JtTG9naW5SZXF1ZXN0LnByb3RvEglwcm90by5u" + "ZXQaFUNvbW1vbnMvRW52SW5mby5wcm90bxoUQ29tbW9ucy9EZWZpbmUucHJv" + "dG8ikQEKFFBsYXRmb3JtTG9naW5SZXF1ZXN0EgsKA3NlcRgBIAEoBRIUCgxh" + "Y2Nlc3NfdG9rZW4YAiABKAkSJAoIZW52X2luZm8YAyABKAsyEi5wcm90by5u" + "ZXQuRW52SW5mbxIwCgR0eXBlGAQgASgOMiIucHJvdG8ubmV0LkRlZmluZV9Q" + "bGF0Zm9ybUxpbmtUeXBlYgZwcm90bzM="), new FileDescriptor[2]
	{
		EnvInfoReflection.Descriptor,
		DefineReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PlatformLoginRequest), PlatformLoginRequest.Parser, new string[4] { "Seq", "AccessToken", "EnvInfo", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
