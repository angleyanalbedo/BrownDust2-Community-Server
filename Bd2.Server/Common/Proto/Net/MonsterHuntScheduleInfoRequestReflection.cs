using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterHuntScheduleInfoRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixSZXF1ZXN0L01vbnN0ZXJIdW50U2NoZWR1bGVJbmZvUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0Ii0KHk1vbnN0ZXJIdW50U2NoZWR1bGVJbmZvUmVxdWVzdBILCgNzZXEYASABKAViBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterHuntScheduleInfoRequest), MonsterHuntScheduleInfoRequest.Parser, new string[1] { "Seq" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
