using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameFieldInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9NaW5pR2FtZUZpZWxkSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaHENvbW1vbnMvTWluaUdhbWVEQkluZm8ucHJvdG8iRAoZTWluaUdhbWVGaWVsZEluZm9SZXNwb25zZRInCgRpbmZvGAEgAygLMhkucHJvdG8ubmV0Lk1pbmlHYW1lREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { MiniGameDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameFieldInfoResponse), MiniGameFieldInfoResponse.Parser, new string[1] { "Info" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
