using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EatFoodResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXNwb25zZS9FYXRGb29kUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoY" + "Q29tbW9ucy9DaGFyREJJbmZvLnByb3RvGh1Db21tb25zL0ZpZWxkQnVmZkRC" + "SW5mby5wcm90byJwCg9FYXRGb29kUmVzcG9uc2USKAoJY2hhcl9pbmZvGAEg" + "AygLMhUucHJvdG8ubmV0LkNoYXJEQkluZm8SMwoPZmllbGRfYnVmZl9pbmZv" + "GAIgAygLMhoucHJvdG8ubmV0LkZpZWxkQnVmZkRCSW5mb2IGcHJvdG8z"), new FileDescriptor[2]
	{
		CharDBInfoReflection.Descriptor,
		FieldBuffDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EatFoodResponse), EatFoodResponse.Parser, new string[2] { "CharInfo", "FieldBuffInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
