using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb21tb25zL1BhY2tEQkluZm8ucHJvdG8SCXByb3RvLm5ldCKjAQoKUGFj" + "a0RCSW5mbxIKCgJpZBgBIAEoBRIZChFjbGVhcl9xdWVzdF9jb3VudBgCIAEo" + "BRIYChBpc19wYWNrX2NvbXBsZXRlGAMgASgIEhMKC3F1ZXN0X2xldmVsGAQg" + "ASgFEhEKCXF1ZXN0X29wdBgFIAEoBRIXCg9zdWJfcXVlc3RfY291bnQYBiAB" + "KAUSEwoLYWN0aXZlX3RpbWUYByABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackDBInfo), PackDBInfo.Parser, new string[7] { "Id", "ClearQuestCount", "IsPackComplete", "QuestLevel", "QuestOpt", "SubQuestCount", "ActiveTime" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
