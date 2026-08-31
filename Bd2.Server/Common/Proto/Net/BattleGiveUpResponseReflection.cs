using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class BattleGiveUpResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXNwb25zZS9CYXR0bGVHaXZlVXBSZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0GhhDb21tb25zL1VzZXJEQkluZm8ucHJvdG8iQAoUQmF0dGxlR2l2ZVVwUmVzcG9uc2USKAoJdXNlcl9pbmZvGAEgASgLMhUucHJvdG8ubmV0LlVzZXJEQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { UserDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(BattleGiveUpResponse), BattleGiveUpResponse.Parser, new string[1] { "UserInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
