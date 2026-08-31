using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipLockRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L0VxdWlwTG9ja1JlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJHChBFcXVpcExvY2tSZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgtpbnZlbl9pbmRleBgCIAEoAxIRCglsb2NrX2ZsYWcYAyABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipLockRequest), EquipLockRequest.Parser, new string[3] { "Seq", "InvenIndex", "LockFlag" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
