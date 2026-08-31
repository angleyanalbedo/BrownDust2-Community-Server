using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class RewardDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb21tb25zL1Jld2FyZERCSW5mby5wcm90bxIJcHJvdG8ubmV0IkYKDFJld2FyZERCSW5mbxIPCgdpdGVtX2lkGAEgASgFEhEKCWl0ZW1fdHlwZRgCIAEoBRISCgppdGVtX2NvdW50GAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(RewardDBInfo), RewardDBInfo.Parser, new string[3] { "ItemId", "ItemType", "ItemCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
