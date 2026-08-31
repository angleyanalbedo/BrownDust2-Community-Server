using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipBatchUseInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Db21tb25zL0VxdWlwQmF0Y2hVc2VJbmZvLnByb3RvEglwcm90by5uZXQiSAoRRXF1aXBCYXRjaFVzZUluZm8SGAoQY2hhcl9pbnZlbl9pbmRleBgBIAEoAxIZChFlcXVpcF9pbnZlbl9pbmRleBgCIAMoA2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipBatchUseInfo), EquipBatchUseInfo.Parser, new string[2] { "CharInvenIndex", "EquipInvenIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
