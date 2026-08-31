using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TutorialInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9UdXRvcmlhbEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0IjEKFFR1dG9yaWFsSW5mb1Jlc3BvbnNlEhkKEXR1dG9yaWFsX2NsZWFyX2lkGAEgAygFYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TutorialInfoResponse), TutorialInfoResponse.Parser, new string[1] { "TutorialClearId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
