using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ProductDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDb21tb25zL1Byb2R1Y3REQkluZm8ucHJvdG8SCXByb3RvLm5ldCIuCg1Qcm9kdWN0REJJbmZvEgoKAmlkGAEgASgFEhEKCWJ1eV9jb3VudBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ProductDBInfo), ProductDBInfo.Parser, new string[2] { "Id", "BuyCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
