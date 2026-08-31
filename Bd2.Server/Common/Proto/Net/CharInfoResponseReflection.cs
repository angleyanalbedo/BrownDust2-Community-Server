using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9DaGFySW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvQ2hhckRCSW5mby5wcm90byJiChBDaGFySW5mb1Jlc3BvbnNlEigKCWNoYXJfaW5mbxgBIAMoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZvEiQKHGZpZWxkX2NoYXJfY29udHJvbF9kZWNrX3R5cGUYAiABKAViBnByb3RvMw=="), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharInfoResponse), CharInfoResponse.Parser, new string[2] { "CharInfo", "FieldCharControlDeckType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
