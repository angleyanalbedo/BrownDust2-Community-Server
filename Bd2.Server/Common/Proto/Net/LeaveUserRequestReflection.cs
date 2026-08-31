using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class LeaveUserRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L0xlYXZlVXNlclJlcXVlc3QucHJvdG8SCXByb3RvLm5ldBoVQ29tbW9ucy9FbnZJbmZvLnByb3RvIkUKEExlYXZlVXNlclJlcXVlc3QSCwoDc2VxGAEgASgFEiQKCGVudl9pbmZvGAIgASgLMhIucHJvdG8ubmV0LkVudkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { EnvInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LeaveUserRequest), LeaveUserRequest.Parser, new string[2] { "Seq", "EnvInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
