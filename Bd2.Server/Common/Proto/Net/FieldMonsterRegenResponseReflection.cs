using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldMonsterRegenResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihSZXNwb25zZS9GaWVsZE1vbnN0ZXJSZWdlblJlc3BvbnNlLnByb3RvEglwcm90by5uZXQaG0NvbW1vbnMvTW9uc3RlckRCSW5mby5wcm90byJLChlGaWVsZE1vbnN0ZXJSZWdlblJlc3BvbnNlEi4KDG1vbnN0ZXJfaW5mbxgBIAEoCzIYLnByb3RvLm5ldC5Nb25zdGVyREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { MonsterDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldMonsterRegenResponse), FieldMonsterRegenResponse.Parser, new string[1] { "MonsterInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
