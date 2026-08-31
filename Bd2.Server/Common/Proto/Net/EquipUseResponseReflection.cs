using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class EquipUseResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXNwb25zZS9FcXVpcFVzZVJlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvQ2hhckRCSW5mby5wcm90byI8ChBFcXVpcFVzZVJlc3BvbnNlEigKCWNoYXJfaW5mbxgBIAEoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EquipUseResponse), EquipUseResponse.Parser, new string[1] { "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
