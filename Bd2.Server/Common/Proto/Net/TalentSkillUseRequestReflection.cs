using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class TalentSkillUseRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZXF1ZXN0L1RhbGVudFNraWxsVXNlUmVxdWVzdC5wcm90bxIJcHJvdG8ubmV0ImAKFVRhbGVudFNraWxsVXNlUmVxdWVzdBILCgNzZXEYASABKAUSEwoLaW52ZW5faW5kZXgYAiABKAMSEQoJb2JqZWN0X2lkGAMgAygFEhIKCmZvb2RfaW5kZXgYBCABKANiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TalentSkillUseRequest), TalentSkillUseRequest.Parser, new string[4] { "Seq", "InvenIndex", "ObjectId", "FoodIndex" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
