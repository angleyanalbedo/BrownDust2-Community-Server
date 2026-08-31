using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipOptionReRollConfirmRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1SZXF1ZXN0L0VxdWlwT3B0aW9uUmVSb2xsQ29uZmlybVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCJdCh9FcXVpcE9wdGlvblJlUm9sbENvbmZpcm1SZXF1ZXN0EgsKA3NlcRgBIAEoBRIZChFlcXVpcF9pbnZlbl9pbmRleBgCIAEoAxISCgppc19jb25maXJtGAMgASgIYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipOptionReRollConfirmRequest), EquipOptionReRollConfirmRequest.Parser, new string[3] { "Seq", "EquipInvenIndex", "IsConfirm" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
