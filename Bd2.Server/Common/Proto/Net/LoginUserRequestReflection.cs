using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class LoginUserRequestReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZXF1ZXN0L0xvZ2luVXNlclJlcXVlc3QucHJvdG8SCXByb3RvLm5ldBoV" + "Q29tbW9ucy9FbnZJbmZvLnByb3RvGhRDb21tb25zL0RlZmluZS5wcm90byL/" + "AgoQTG9naW5Vc2VyUmVxdWVzdBILCgNzZXEYASABKAUSFAoMYWNjZXNzX3Rv" + "a2VuGAIgASgJEhMKC21hcmtldF90eXBlGAMgASgFEg8KB3ZlcnNpb24YBCAB" + "KAkSDwoHdXNlcl9vcxgFIAEoCRIkCghlbnZfaW5mbxgGIAEoCzISLnByb3Rv" + "Lm5ldC5FbnZJbmZvEjUKDWxhbmd1YWdlX3R5cGUYByABKA4yHi5wcm90by5u" + "ZXQuRGVmaW5lX0xhbmd1YWdlVHlwZRIeChZyZXNvdXJjZV9kb3dubG9hZF90" + "eXBlGAggASgFEjsKE2xhbmd1YWdlX3NvdW5kX3R5cGUYCSABKA4yHi5wcm90" + "by5uZXQuRGVmaW5lX0xhbmd1YWdlVHlwZRIXCg9zY3JlZW5fZml4X3R5cGUY" + "CiABKAUSPgoSYnVuZGxlX29wdGlvbl90eXBlGAsgASgOMiIucHJvdG8ubmV0" + "LkRlZmluZV9CdW5kbGVPcHRpb25UeXBlYgZwcm90bzM="), new FileDescriptor[2]
	{
		EnvInfoReflection.Descriptor,
		DefineReflection.Descriptor
	}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LoginUserRequest), LoginUserRequest.Parser, new string[11]
		{
			"Seq", "AccessToken", "MarketType", "Version", "UserOs", "EnvInfo", "LanguageType", "ResourceDownloadType", "LanguageSoundType", "ScreenFixType",
			"BundleOptionType"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
