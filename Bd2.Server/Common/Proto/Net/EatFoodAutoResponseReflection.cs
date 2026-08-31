using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EatFoodAutoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9FYXRGb29kQXV0b1Jlc3BvbnNlLnByb3RvEglwcm90by5u" + "ZXQinAEKE0VhdEZvb2RBdXRvUmVzcG9uc2USSwoScmVjb3ZlcnlfY2hhcl9p" + "bmZvGAEgAygLMi8ucHJvdG8ubmV0LkVhdEZvb2RBdXRvUmVzcG9uc2UuUmVj" + "b3ZlcnlDaGFySW5mbxo4ChBSZWNvdmVyeUNoYXJJbmZvEhgKEGNoYXJfaW52" + "ZW5faW5kZXgYASABKAMSCgoCaHAYAiABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EatFoodAutoResponse), EatFoodAutoResponse.Parser, new string[1] { "RecoveryCharInfo" }, null, null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EatFoodAutoResponse.Types.RecoveryCharInfo), EatFoodAutoResponse.Types.RecoveryCharInfo.Parser, new string[2] { "CharInvenIndex", "Hp" }, null, null, null, null)
		})
	}));

	public static FileDescriptor Descriptor => descriptor;
}
