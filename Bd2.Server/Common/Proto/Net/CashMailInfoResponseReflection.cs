using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CashMailInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9DYXNoTWFpbEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8u" + "bmV0GhhDb21tb25zL01haWxEQkluZm8ucHJvdG8ibgoUQ2FzaE1haWxJbmZv" + "UmVzcG9uc2USKAoJbWFpbF9pbmZvGAEgAygLMhUucHJvdG8ubmV0Lk1haWxE" + "QkluZm8SEwoLdG90YWxfY291bnQYAiABKAUSFwoPbWF4X2ludmVuX2luZGV4" + "GAMgASgDYgZwcm90bzM="), new FileDescriptor[1] { MailDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CashMailInfoResponse), CashMailInfoResponse.Parser, new string[3] { "MailInfo", "TotalCount", "MaxInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
