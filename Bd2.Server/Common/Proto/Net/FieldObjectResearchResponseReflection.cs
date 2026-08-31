using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class FieldObjectResearchResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipSZXNwb25zZS9GaWVsZE9iamVjdFJlc2VhcmNoUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvIlYKG0ZpZWxkT2JqZWN0UmVzZWFyY2hSZXNwb25zZRILCgNzZXEYASABKAUSKgoLcmV3YXJkX2l0ZW0YAiADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mb2IGcHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(FieldObjectResearchResponse), FieldObjectResearchResponse.Parser, new string[2] { "Seq", "RewardItem" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
