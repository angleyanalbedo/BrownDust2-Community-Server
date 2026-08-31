using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class GachaStepUpUserDBInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDb21tb25zL0dhY2hhU3RlcFVwVXNlckRCSW5mby5wcm90bxIJcHJvdG8ubmV0IjUKFUdhY2hhU3RlcFVwVXNlckRCSW5mbxIQCghncm91cF9pZBgBIAEoBRIKCgJpZBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GachaStepUpUserDBInfo), GachaStepUpUserDBInfo.Parser, new string[2] { "GroupId", "Id" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
