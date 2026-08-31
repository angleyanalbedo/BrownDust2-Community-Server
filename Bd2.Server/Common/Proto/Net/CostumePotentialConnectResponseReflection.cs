using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CostumePotentialConnectResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXNwb25zZS9Db3N0dW1lUG90ZW50aWFsQ29ubmVjdFJlc3BvbnNlLnByb3RvEglwcm90by5uZXQaGENvbW1vbnMvQ2hhckRCSW5mby5wcm90byJLCh9Db3N0dW1lUG90ZW50aWFsQ29ubmVjdFJlc3BvbnNlEigKCWNoYXJfaW5mbxgBIAMoCzIVLnByb3RvLm5ldC5DaGFyREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { CharDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CostumePotentialConnectResponse), CostumePotentialConnectResponse.Parser, new string[1] { "CharInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
