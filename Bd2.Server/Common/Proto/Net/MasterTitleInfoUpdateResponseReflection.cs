using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MasterTitleInfoUpdateResponseReflection
{
	public static FileDescriptor Descriptor => descriptor;

	private static readonly FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(
		Convert.FromBase64String(
			"CixSZXNwb25zZS9NYXN0ZXJUaXRsZUluZm9VcGRhdGVSZXNwb25zZS5wcm90" +
			"bxIJcHJvdG8ubmV0Ih8KHU1hc3RlclRpdGxlSW5mb1VwZGF0ZVJlc3BvbnNl" +
			"YgZwcm90bzM="),
		new FileDescriptor[0],
		new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new(typeof(MasterTitleInfoUpdateResponse), MasterTitleInfoUpdateResponse.Parser, null, null, null, null, null)
		}));
}
