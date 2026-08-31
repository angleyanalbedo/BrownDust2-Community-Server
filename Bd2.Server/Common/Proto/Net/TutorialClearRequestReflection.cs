using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TutorialClearRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXF1ZXN0L1R1dG9yaWFsQ2xlYXJSZXF1ZXN0LnByb3RvEglwcm90by5uZXQiPgoUVHV0b3JpYWxDbGVhclJlcXVlc3QSCwoDc2VxGAEgASgFEhkKEWNsZWFyX3R1dG9yaWFsX2lkGAIgASgFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TutorialClearRequest), TutorialClearRequest.Parser, new string[2] { "Seq", "ClearTutorialId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
