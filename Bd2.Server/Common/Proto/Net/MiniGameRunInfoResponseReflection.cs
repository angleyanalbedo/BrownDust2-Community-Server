using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameRunInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9NaW5pR2FtZVJ1bkluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhxDb21tb25zL01pbmlHYW1lREJJbmZvLnByb3RvIkIKF01pbmlHYW1lUnVuSW5mb1Jlc3BvbnNlEicKBGluZm8YASADKAsyGS5wcm90by5uZXQuTWluaUdhbWVEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { MiniGameDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameRunInfoResponse), MiniGameRunInfoResponse.Parser, new string[1] { "Info" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
