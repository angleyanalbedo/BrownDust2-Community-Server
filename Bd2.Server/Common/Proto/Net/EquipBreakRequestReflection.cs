using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipBreakRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXF1ZXN0L0VxdWlwQnJlYWtSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiNQoRRXF1aXBCcmVha1JlcXVlc3QSCwoDc2VxGAEgASgFEhMKC2ludmVuX2luZGV4GAIgAygDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipBreakRequest), EquipBreakRequest.Parser, new string[2] { "Seq", "InvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
