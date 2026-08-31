using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class AttendanceAlwaysGroupTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkBjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0F0dGVuZGFuY2VB" + "bHdheXNHcm91cFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIkkK" + "GkF0dGVuZGFuY2VBbHdheXNHcm91cFRhYmxlEg8KB2dyb3VwSWQYASABKAUS" + "CgoCaWQYAiABKAUSDgoGbmV4dElkGAMgASgFQkRCE1Byb3RvLkRlc2lnbi5j" + "b21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVzaWdu" + "LmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AttendanceAlwaysGroupTable), AttendanceAlwaysGroupTable.Parser, new string[3] { "GroupId", "Id", "NextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
