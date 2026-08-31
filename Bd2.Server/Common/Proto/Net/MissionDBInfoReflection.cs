using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MissionDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDb21tb25zL01pc3Npb25EQkluZm8ucHJvdG8SCXByb3RvLm5ldCJlCg1NaXNzaW9uREJJbmZvEhAKCGdyb3VwX2lkGAEgASgFEgoKAmlkGAIgASgFEhIKCmdyb3VwX3R5cGUYAyABKAUSDQoFdmFsdWUYBCABKAUSEwoLaXNfY29tcGxldGUYBSABKAhiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MissionDBInfo), MissionDBInfo.Parser, new string[5] { "GroupId", "Id", "GroupType", "Value", "IsComplete" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
