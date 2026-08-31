using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class LogoutUserRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L0xvZ291dFVzZXJSZXF1ZXN0LnByb3RvEglwcm90by5uZXQaFUNvbW1vbnMvRW52SW5mby5wcm90byJGChFMb2dvdXRVc2VyUmVxdWVzdBILCgNzZXEYASABKAUSJAoIZW52X2luZm8YAiABKAsyEi5wcm90by5uZXQuRW52SW5mb2IGcHJvdG8z"), new FileDescriptor[1] { EnvInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LogoutUserRequest), LogoutUserRequest.Parser, new string[2] { "Seq", "EnvInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
