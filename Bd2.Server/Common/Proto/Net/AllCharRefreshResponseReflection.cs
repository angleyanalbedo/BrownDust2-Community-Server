using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AllCharRefreshResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9BbGxDaGFyUmVmcmVzaFJlc3BvbnNlLnByb3RvEglwcm90" + "by5uZXQaJUNvbW1vbnMvUGljdG9yaWFsQnVmZlN0YXREQkluZm8ucHJvdG8i" + "VAoWQWxsQ2hhclJlZnJlc2hSZXNwb25zZRI6Cg5idWZmX3N0YXRfaW5mbxgB" + "IAMoCzIiLnByb3RvLm5ldC5QaWN0b3JpYWxCdWZmU3RhdERCSW5mb2IGcHJv" + "dG8z"), new FileDescriptor[1] { PictorialBuffStatDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AllCharRefreshResponse), AllCharRefreshResponse.Parser, new string[1] { "BuffStatInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
