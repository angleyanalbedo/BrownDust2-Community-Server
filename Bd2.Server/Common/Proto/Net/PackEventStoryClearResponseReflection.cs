using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PackEventStoryClearResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9QYWNrRXZlbnRTdG9yeUNsZWFyUmVzcG9uc2UucHJvdG8S" + "CXByb3RvLm5ldBogQ29tbW9ucy9SZXdhcmREQkluZm9CdW5kbGUucHJvdG8a" + "IkNvbW1vbnMvUGFja0V2ZW50U3RvcnlEQkluZm8ucHJvdG8ijQEKG1BhY2tF" + "dmVudFN0b3J5Q2xlYXJSZXNwb25zZRI5ChJyZXdhcmRfaW5mb19idW5kbGUY" + "ASABKAsyHS5wcm90by5uZXQuUmV3YXJkREJJbmZvQnVuZGxlEjMKCmNsZWFy" + "X2luZm8YAiABKAsyHy5wcm90by5uZXQuUGFja0V2ZW50U3RvcnlEQkluZm9i" + "BnByb3RvMw=="), new FileDescriptor[2]
	{
		RewardDBInfoBundleReflection.Descriptor,
		PackEventStoryDBInfoReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PackEventStoryClearResponse), PackEventStoryClearResponse.Parser, new string[2] { "RewardInfoBundle", "ClearInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
