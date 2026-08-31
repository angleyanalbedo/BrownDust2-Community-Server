using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class JoinUserResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9Kb2luVXNlclJlc3BvbnNlLnByb3RvEglwcm90by5uZXQa" + "IENvbW1vbnMvUmV3YXJkREJJbmZvQnVuZGxlLnByb3RvGhhDb21tb25zL1Vz" + "ZXJEQkluZm8ucHJvdG8idwoQSm9pblVzZXJSZXNwb25zZRIoCgl1c2VyX2lu" + "Zm8YASABKAsyFS5wcm90by5uZXQuVXNlckRCSW5mbxI5ChJyZXdhcmRfaW5m" + "b19idW5kbGUYAiABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxl" + "YgZwcm90bzM="), new FileDescriptor[2]
	{
		RewardDBInfoBundleReflection.Descriptor,
		UserDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(JoinUserResponse), JoinUserResponse.Parser, new string[2] { "UserInfo", "RewardInfoBundle" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
