using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class SelectPlatformOtherDataResponseReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci5SZXNwb25zZS9TZWxlY3RQbGF0Zm9ybU90aGVyRGF0YVJlc3BvbnNlLnBy" + "b3RvEglwcm90by5uZXQaGENvbW1vbnMvVXNlckRCSW5mby5wcm90byKEAQof" + "U2VsZWN0UGxhdGZvcm1PdGhlckRhdGFSZXNwb25zZRIxChJwbGF0Zm9ybV91" + "c2VyX2luZm8YASABKAsyFS5wcm90by5uZXQuVXNlckRCSW5mbxIuCg9ndWVz" + "dF91c2VyX2luZm8YAiABKAsyFS5wcm90by5uZXQuVXNlckRCSW5mb2IGcHJv" + "dG8z"), new FileDescriptor[1] { UserDBInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(SelectPlatformOtherDataResponse), SelectPlatformOtherDataResponse.Parser, new string[2] { "PlatformUserInfo", "GuestUserInfo" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
