using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CharHealingResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9DaGFySGVhbGluZ1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvQ2hhckRCSW5mby5wcm90byJXChNDaGFySGVhbGluZ1Jlc3BvbnNlEigKCWNoYXJfaW5mbxgBIAMoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZvEhYKDmFkZF90YWxlbnRfZXhwGAIgASgFYgZwcm90bzM="), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharHealingResponse), CharHealingResponse.Parser, new string[2] { "CharInfo", "AddTalentExp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
