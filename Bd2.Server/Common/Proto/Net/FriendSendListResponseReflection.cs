using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendSendListResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9GcmllbmRTZW5kTGlzdFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGkNvbW1vbnMvRnJpZW5kREJJbmZvLnByb3RvIkYKFkZyaWVuZFNlbmRMaXN0UmVzcG9uc2USLAoLZnJpZW5kX2luZm8YASADKAsyFy5wcm90by5uZXQuRnJpZW5kREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { FriendDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendSendListResponse), FriendSendListResponse.Parser, new string[1] { "FriendInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
