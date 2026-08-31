using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class ChargeCostInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVSZXNwb25zZS9DaGFyZ2VDb3N0SW5mb1Jlc3BvbnNlLnByb3RvEglwcm90by5uZXQaHENvbW1vbnMvQ29zdFRpbWVEQkluZm8ucHJvdG8iSwoWQ2hhcmdlQ29zdEluZm9SZXNwb25zZRIxCg5jb3N0X3RpbWVfaW5mbxgBIAMoCzIZLnByb3RvLm5ldC5Db3N0VGltZURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { CostTimeDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ChargeCostInfoResponse), ChargeCostInfoResponse.Parser, new string[1] { "CostTimeInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
