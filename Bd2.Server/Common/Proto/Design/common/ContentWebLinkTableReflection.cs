using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class ContentWebLinkTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkNjb21tb24uZGIvR2FtZURlZmF1bHRUYWJsZV9fX+q4sOuzuOyEpOyglS9D" + "b250ZW50V2ViTGlua1RhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9u" + "IpQBChNDb250ZW50V2ViTGlua1RhYmxlEgoKAmlkGAEgASgFEhUKDWxpbmtV" + "cmxQYXRoQ24YAiABKAkSFQoNbGlua1VybFBhdGhFbhgDIAEoCRIVCg1saW5r" + "VXJsUGF0aEpwGAQgASgJEhUKDWxpbmtVcmxQYXRoS3IYBSABKAkSFQoNbGlu" + "a1VybFBhdGhUdxgGIAEoCUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4v" + "UHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(ContentWebLinkTable), ContentWebLinkTable.Parser, new string[6] { "Id", "LinkUrlPathCn", "LinkUrlPathEn", "LinkUrlPathJp", "LinkUrlPathKr", "LinkUrlPathTw" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
