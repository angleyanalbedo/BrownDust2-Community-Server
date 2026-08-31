using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SaveTotalBattlePowerResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitSZXNwb25zZS9TYXZlVG90YWxCYXR0bGVQb3dlclJlc3BvbnNlLnByb3RvEglwcm90by5uZXQiQgocU2F2ZVRvdGFsQmF0dGxlUG93ZXJSZXNwb25zZRIiChpoaWdoZXN0X3RvdGFsX2JhdHRsZV9wb3dlchgBIAEoBWIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SaveTotalBattlePowerResponse), SaveTotalBattlePowerResponse.Parser, new string[1] { "HighestTotalBattlePower" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
