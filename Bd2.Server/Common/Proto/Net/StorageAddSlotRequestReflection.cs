using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class StorageAddSlotRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L1N0b3JhZ2VBZGRTbG90UmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IjYKFVN0b3JhZ2VBZGRTbG90UmVxdWVzdBILCgNzZXEYASABKAUSEAoIYWRkX3Nsb3QYAiABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(StorageAddSlotRequest), StorageAddSlotRequest.Parser, new string[2] { "Seq", "AddSlot" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
