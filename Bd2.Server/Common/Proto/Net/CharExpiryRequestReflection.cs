using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharExpiryRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L0NoYXJFeHBpcnlSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiOgoRQ2hhckV4cGlyeVJlcXVlc3QSCwoDc2VxGAEgASgFEhgKEGNoYXJfaW52ZW5faW5kZXgYAiABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharExpiryRequest), CharExpiryRequest.Parser, new string[2] { "Seq", "CharInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
