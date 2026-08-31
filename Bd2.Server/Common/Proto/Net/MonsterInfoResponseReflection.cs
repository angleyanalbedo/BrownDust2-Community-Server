using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MonsterInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9Nb25zdGVySW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaG0NvbW1vbnMvTW9uc3RlckRCSW5mby5wcm90byJFChNNb25zdGVySW5mb1Jlc3BvbnNlEi4KDG1vbnN0ZXJfaW5mbxgBIAMoCzIYLnByb3RvLm5ldC5Nb25zdGVyREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { MonsterDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MonsterInfoResponse), MonsterInfoResponse.Parser, new string[1] { "MonsterInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
