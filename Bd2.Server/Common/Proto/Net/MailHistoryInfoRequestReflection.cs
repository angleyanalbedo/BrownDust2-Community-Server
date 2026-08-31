using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MailHistoryInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L01haWxIaXN0b3J5SW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJWChZNYWlsSGlzdG9yeUluZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBRIZChFzdGFydF9pbnZlbl9pbmRleBgCIAEoAxIUCgxzZWxlY3RfY291bnQYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MailHistoryInfoRequest), MailHistoryInfoRequest.Parser, new string[3] { "Seq", "StartInvenIndex", "SelectCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
