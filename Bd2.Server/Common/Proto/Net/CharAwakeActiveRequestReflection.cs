using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharAwakeActiveRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRSZXF1ZXN0L0NoYXJBd2FrZUFjdGl2ZVJlcXVlc3QucHJvdG8SCXByb3Rv" + "Lm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvImkKFkNoYXJBd2FrZUFj" + "dGl2ZVJlcXVlc3QSCwoDc2VxGAEgASgFEhgKEGNoYXJfaW52ZW5faW5kZXgY" + "AiABKAMSKAoJaXRlbV9pbmZvGAMgAygLMhUucHJvdG8ubmV0Lkl0ZW1EQklu" + "Zm9iBnByb3RvMw=="), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharAwakeActiveRequest), CharAwakeActiveRequest.Parser, new string[3] { "Seq", "CharInvenIndex", "ItemInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
