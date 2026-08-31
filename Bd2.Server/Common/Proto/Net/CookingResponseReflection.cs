using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class CookingResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXNwb25zZS9Db29raW5nUmVzcG9uc2UucHJvdG8SCXByb3RvLm5ldBoYQ29tbW9ucy9JdGVtREJJbmZvLnByb3RvIlMKD0Nvb2tpbmdSZXNwb25zZRIoCglpdGVtX2luZm8YASADKAsyFS5wcm90by5uZXQuSXRlbURCSW5mbxIWCg5hZGRfdGFsZW50X2V4cBgCIAEoBWIGcHJvdG8z"), new FileDescriptor[1] { ItemDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CookingResponse), CookingResponse.Parser, new string[2] { "ItemInfo", "AddTalentExp" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
