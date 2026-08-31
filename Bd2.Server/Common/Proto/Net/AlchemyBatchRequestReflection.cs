using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AlchemyBatchRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXF1ZXN0L0FsY2hlbXlCYXRjaFJlcXVlc3QucHJvdG8SCXByb3RvLm5l" + "dBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvIowBChNBbGNoZW15QmF0Y2hS" + "ZXF1ZXN0EgsKA3NlcRgBIAEoBRITCgtpbnZlbl9pbmRleBgCIAEoAxISCgph" + "bGNoZW15X2lkGAMgASgFEhUKDWFsY2hlbXlfY291bnQYBCABKAUSKAoJaXRl" + "bV9pbmZvGAUgAygLMhUucHJvdG8ubmV0Lkl0ZW1EQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AlchemyBatchRequest), AlchemyBatchRequest.Parser, new string[5] { "Seq", "InvenIndex", "AlchemyId", "AlchemyCount", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
