using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class HuntingGroundEnterResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilSZXNwb25zZS9IdW50aW5nR3JvdW5kRW50ZXJSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhtDb21tb25zL01vbnN0ZXJEQkluZm8ucHJvdG8iTAoaSHVudGluZ0dyb3VuZEVudGVyUmVzcG9uc2USLgoMbW9uc3Rlcl9pbmZvGAEgAygLMhgucHJvdG8ubmV0Lk1vbnN0ZXJEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { MonsterDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(HuntingGroundEnterResponse), HuntingGroundEnterResponse.Parser, new string[1] { "MonsterInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
