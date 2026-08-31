using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class AttendanceLimitRewardTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkBjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0F0dGVuZGFuY2VM" + "aW1pdFJld2FyZFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIk4K" + "GkF0dGVuZGFuY2VMaW1pdFJld2FyZFRhYmxlEg8KB2dyb3VwSWQYASABKAUS" + "CgoCaWQYAiABKAUSEwoLcmFuZG9tQm94SWQYAyABKAVCREITUHJvdG8uRGVz" + "aWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90by5E" + "ZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AttendanceLimitRewardTable), AttendanceLimitRewardTable.Parser, new string[3] { "GroupId", "Id", "RandomBoxId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
