using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MailHistoryInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9NYWlsSGlzdG9yeUluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL01haWxEQkluZm8ucHJvdG8iWAoXTWFpbEhpc3RvcnlJbmZvUmVzcG9uc2USKAoJbWFpbF9pbmZvGAEgAygLMhUucHJvdG8ubmV0Lk1haWxEQkluZm8SEwoLdG90YWxfY291bnQYAiABKAViBnByb3RvMw=="), new FileDescriptor[1] { MailDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MailHistoryInfoResponse), MailHistoryInfoResponse.Parser, new string[2] { "MailInfo", "TotalCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
