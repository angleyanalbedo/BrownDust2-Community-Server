using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackEventStoryDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDb21tb25zL1BhY2tFdmVudFN0b3J5REJJbmZvLnByb3RvEglwcm90by5uZXQiRwoUUGFja0V2ZW50U3RvcnlEQkluZm8SEQoJZXZlbnRfdWlkGAEgASgFEhAKCGdyb3VwX2lkGAIgASgFEgoKAmlkGAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventStoryDBInfo), PackEventStoryDBInfo.Parser, new string[3] { "EventUid", "GroupId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
