using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipsUseRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L0VxdWlwc1VzZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJIChBFcXVpcHNVc2VSZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgtlcXVpcF9pbmRleBgCIAMoAxISCgpjaGFyX2luZGV4GAMgASgDYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipsUseRequest), EquipsUseRequest.Parser, new string[3] { "Seq", "EquipIndex", "CharIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
