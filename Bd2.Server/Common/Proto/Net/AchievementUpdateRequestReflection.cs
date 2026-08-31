using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AchievementUpdateRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXF1ZXN0L0FjaGlldmVtZW50VXBkYXRlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0IkwKGEFjaGlldmVtZW50VXBkYXRlUmVxdWVzdBILCgNzZXEYASABKAUSEAoIZ3JvdXBfaWQYAiABKAUSEQoJYWRkX3ZhbHVlGAMgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AchievementUpdateRequest), AchievementUpdateRequest.Parser, new string[3] { "Seq", "GroupId", "AddValue" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
