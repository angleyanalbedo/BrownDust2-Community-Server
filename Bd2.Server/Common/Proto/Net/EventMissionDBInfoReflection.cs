using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EventMissionDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb21tb25zL0V2ZW50TWlzc2lvbkRCSW5mby5wcm90bxIJcHJvdG8ubmV0ImgKEkV2ZW50TWlzc2lvbkRCSW5mbxIQCghldmVudF9pZBgBIAEoAxIQCghncm91cF9pZBgCIAEoBRIKCgJpZBgDIAEoBRINCgV2YWx1ZRgEIAEoBRITCgtpc19jb21wbGV0ZRgFIAEoCGIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EventMissionDBInfo), EventMissionDBInfo.Parser, new string[5] { "EventId", "GroupId", "Id", "Value", "IsComplete" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
