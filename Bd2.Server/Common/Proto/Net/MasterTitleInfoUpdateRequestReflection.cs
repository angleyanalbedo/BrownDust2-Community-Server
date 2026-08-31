using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MasterTitleInfoUpdateRequestReflection
{
	public static FileDescriptor Descriptor => descriptor;

	private static readonly FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(
		Convert.FromBase64String(
			"CipSZXF1ZXN0L01hc3RlclRpdGxlSW5mb1VwZGF0ZVJlcXVlc3QucHJvdG8S" +
			"CXByb3RvLm5ldCJVChxNYXN0ZXJUaXRsZUluZm9VcGRhdGVSZXF1ZXN0EgsK" +
			"A3NlcRgBIAEoBRIMCgRuYW1lGAIgASgJEg0KBW1vbnRoGAMgASgFEgsKA2Rh" +
			"eRgEIAEoBWIGcHJvdG8z"),
		new FileDescriptor[0],
		new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new(typeof(MasterTitleInfoUpdateRequest), MasterTitleInfoUpdateRequest.Parser, new string[] { "Seq", "Name", "Month", "Day" }, null, null, null, null)
		}));
}
