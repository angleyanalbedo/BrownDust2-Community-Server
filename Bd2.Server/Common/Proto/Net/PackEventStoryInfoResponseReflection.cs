using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackEventStoryInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9QYWNrRXZlbnRTdG9yeUluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GiJDb21tb25zL1BhY2tFdmVudFN0b3J5REJJbmZvLnByb3RvIksKGlBhY2tFdmVudFN0b3J5SW5mb1Jlc3BvbnNlEi0KBGluZm8YASADKAsyHy5wcm90by5uZXQuUGFja0V2ZW50U3RvcnlEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { PackEventStoryDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventStoryInfoResponse), PackEventStoryInfoResponse.Parser, new string[1] { "Info" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
