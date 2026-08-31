using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MiniGameRunEndRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L01pbmlHYW1lUnVuRW5kUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0ImoKFU1pbmlHYW1lUnVuRW5kUmVxdWVzdBILCgNzZXEYASABKAUSFAoMaXNfZm9yY2VfZW5kGAIgASgIEhQKDHJlY29yZF92YWx1ZRgDIAEoBRIYChByZWNvcmRfcGxheV9pbmZvGAQgASgJYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MiniGameRunEndRequest), MiniGameRunEndRequest.Parser, new string[4] { "Seq", "IsForceEnd", "RecordValue", "RecordPlayInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
