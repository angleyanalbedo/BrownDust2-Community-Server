using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntDispatchRewardPreviewRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXF1ZXN0L0h1bnREaXNwYXRjaFJld2FyZFByZXZpZXdSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiaQogSHVudERpc3BhdGNoUmV3YXJkUHJldmlld1JlcXVlc3QSCwoDc2VxGAEgASgFEh4KFmh1bnRfZGlzcGF0Y2hfZ3JvdXBfaWQYAiABKAUSGAoQaHVudF9kaXNwYXRjaF9pZBgDIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchRewardPreviewRequest), HuntDispatchRewardPreviewRequest.Parser, new string[3] { "Seq", "HuntDispatchGroupId", "HuntDispatchId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
