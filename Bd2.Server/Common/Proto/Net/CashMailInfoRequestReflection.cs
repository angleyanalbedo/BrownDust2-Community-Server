using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CashMailInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L0Nhc2hNYWlsSW5mb1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJTChNDYXNoTWFpbEluZm9SZXF1ZXN0EgsKA3NlcRgBIAEoBRIZChFzdGFydF9pbnZlbl9pbmRleBgCIAEoAxIUCgxzZWxlY3RfY291bnQYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CashMailInfoRequest), CashMailInfoRequest.Parser, new string[3] { "Seq", "StartInvenIndex", "SelectCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
