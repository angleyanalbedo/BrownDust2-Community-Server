using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntDispatchDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL0h1bnREaXNwYXRjaERCSW5mby5wcm90bxIJcHJvdG8ubmV0" + "IsMBChJIdW50RGlzcGF0Y2hEQkluZm8SHgoWaHVudF9kaXNwYXRjaF9ncm91" + "cF9pZBgBIAEoBRIYChBodW50X2Rpc3BhdGNoX2lkGAIgASgFEg0KBWNvdW50" + "GAMgASgFEhIKCnN0YXJ0X3RpbWUYBCABKAMSEAoIZW5kX3RpbWUYBSABKAMS" + "HgoWZGVjcmVhc2VfZnJlZV9hcF9jb3VudBgGIAEoBRIeChZkZWNyZWFzZV9j" + "YXNoX2FwX2NvdW50GAcgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntDispatchDBInfo), HuntDispatchDBInfo.Parser, new string[7] { "HuntDispatchGroupId", "HuntDispatchId", "Count", "StartTime", "EndTime", "DecreaseFreeApCount", "DecreaseCashApCount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
