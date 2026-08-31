using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipClearRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L0VxdWlwQ2xlYXJSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiSQoRRXF1aXBDbGVhclJlcXVlc3QSCwoDc2VxGAEgASgFEhMKC2VxdWlwX2luZGV4GAIgASgDEhIKCmNoYXJfaW5kZXgYAyABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipClearRequest), EquipClearRequest.Parser, new string[3] { "Seq", "EquipIndex", "CharIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
