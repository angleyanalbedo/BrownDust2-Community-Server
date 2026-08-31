using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class UserNicknameChangeRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXF1ZXN0L1VzZXJOaWNrbmFtZUNoYW5nZVJlcXVlc3QucHJvdG8SCXByb3RvLm5ldCI5ChlVc2VyTmlja25hbWVDaGFuZ2VSZXF1ZXN0EgsKA3NlcRgBIAEoBRIPCgd1c2VyX2lkGAIgASgJYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(UserNicknameChangeRequest), UserNicknameChangeRequest.Parser, new string[2] { "Seq", "UserId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
