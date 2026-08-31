using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ShopOpenResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9TaG9wT3BlblJlc3BvbnNlLnByb3RvEglwcm90by5uZXQiTgoQU2hvcE9wZW5SZXNwb25zZRIYChByZXB1dGF0aW9uX3N0YXRlGAEgASgFEiAKGGlzX3RhbGVudF9za2lsbF9kaXNjb3VudBgCIAEoCGIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ShopOpenResponse), ShopOpenResponse.Parser, new string[2] { "ReputationState", "IsTalentSkillDiscount" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
