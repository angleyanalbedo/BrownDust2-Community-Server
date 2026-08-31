using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectInfoResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZSZXNwb25zZS9GaWVsZE9iamVjdEluZm9SZXNwb25zZS5wcm90bxIJcHJv" + "dG8ubmV0Gh9Db21tb25zL0ZpZWxkT2JqZWN0REJJbmZvLnByb3RvIpkBChdG" + "aWVsZE9iamVjdEluZm9SZXNwb25zZRI+ChhmaWVsZF9yZXdhcmRfb2J0YWlu" + "X2luZm8YASADKAsyHC5wcm90by5uZXQuRmllbGRPYmplY3REQkluZm8SPgoY" + "ZmllbGRfYWN0aW9uX29iamVjdF9pbmZvGAIgAygLMhwucHJvdG8ubmV0LkZp" + "ZWxkT2JqZWN0REJJbmZvYgZwcm90bzM="), new FileDescriptor[1] { FieldObjectDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectInfoResponse), FieldObjectInfoResponse.Parser, new string[2] { "FieldRewardObtainInfo", "FieldActionObjectInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
