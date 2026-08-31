using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FriendInfoListResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9GcmllbmRJbmZvTGlzdFJlc3BvbnNlLnByb3RvEglwcm90" + "by5uZXQaGkNvbW1vbnMvRnJpZW5kREJJbmZvLnByb3RvIqIBChZGcmllbmRJ" + "bmZvTGlzdFJlc3BvbnNlEiwKC2ZyaWVuZF9pbmZvGAEgAygLMhcucHJvdG8u" + "bmV0LkZyaWVuZERCSW5mbxIsCgtmcmllbmRfcmVjdhgCIAMoCzIXLnByb3Rv" + "Lm5ldC5GcmllbmREQkluZm8SLAoLZnJpZW5kX3NlbmQYAyADKAsyFy5wcm90" + "by5uZXQuRnJpZW5kREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { FriendDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FriendInfoListResponse), FriendInfoListResponse.Parser, new string[3] { "FriendInfo", "FriendRecv", "FriendSend" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
