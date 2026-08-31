using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class AttendanceAlwaysTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvRXZlbnRUYWJsZV9f7J2067Kk7Yq4L0F0dGVuZGFuY2VB" + "bHdheXNUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiJUChVBdHRl" + "bmRhbmNlQWx3YXlzVGFibGUSFQoNYWx3YXlzR3JvdXBJZBgBIAEoBRIKCgJp" + "ZBgCIAEoBRIYChB0aXRsZUxvY2FsVGV4dElkGAMgASgJQkRCE1Byb3RvLkRl" + "c2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8u" + "RGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AttendanceAlwaysTable), AttendanceAlwaysTable.Parser, new string[3] { "AlwaysGroupId", "Id", "TitleLocalTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
