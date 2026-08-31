using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostumeInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSZXNwb25zZS9Db3N0dW1lSW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaG0NvbW1vbnMvQ29zdHVtZURCSW5mby5wcm90byJFChNDb3N0dW1lSW5mb1Jlc3BvbnNlEi4KDGNvc3R1bWVfaW5mbxgBIAMoCzIYLnByb3RvLm5ldC5Db3N0dW1lREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { CostumeDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumeInfoResponse), CostumeInfoResponse.Parser, new string[1] { "CostumeInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
