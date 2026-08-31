using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class DispatchInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9EaXNwYXRjaEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhxDb21tb25zL0Rpc3BhdGNoREJJbmZvLnByb3RvIkgKFERpc3BhdGNoSW5mb1Jlc3BvbnNlEjAKDWRpc3BhdGNoX2luZm8YASADKAsyGS5wcm90by5uZXQuRGlzcGF0Y2hEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { DispatchDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(DispatchInfoResponse), DispatchInfoResponse.Parser, new string[1] { "DispatchInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
