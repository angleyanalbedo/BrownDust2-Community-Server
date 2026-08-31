using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class AchievementInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9BY2hpZXZlbWVudEluZm9SZXNwb25zZS5wcm90bxIJcHJvdG8ubmV0Gh9Db21tb25zL0FjaGlldmVtZW50REJJbmZvLnByb3RvIlEKF0FjaGlldmVtZW50SW5mb1Jlc3BvbnNlEjYKEGFjaGlldmVtZW50X2luZm8YASADKAsyHC5wcm90by5uZXQuQWNoaWV2ZW1lbnREQkluZm9iBnByb3RvMw=="), new FileDescriptor[1] { AchievementDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(AchievementInfoResponse), AchievementInfoResponse.Parser, new string[1] { "AchievementInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
