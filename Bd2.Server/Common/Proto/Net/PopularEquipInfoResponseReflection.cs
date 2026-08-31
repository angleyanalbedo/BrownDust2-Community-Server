using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class PopularEquipInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidSZXNwb25zZS9Qb3B1bGFyRXF1aXBJbmZvUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBogQ29tbW9ucy9Qb3B1bGFyRXF1aXBEQkluZm8ucHJvdG8iRwoYUG9wdWxhckVxdWlwSW5mb1Jlc3BvbnNlEisKBGluZm8YASADKAsyHS5wcm90by5uZXQuUG9wdWxhckVxdWlwREJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { PopularEquipDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(PopularEquipInfoResponse), PopularEquipInfoResponse.Parser, new string[1] { "Info" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
