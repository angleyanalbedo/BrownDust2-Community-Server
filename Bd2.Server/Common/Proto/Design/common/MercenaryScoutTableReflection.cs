using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class MercenaryScoutTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CkJjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL01l" + "cmNlbmFyeVNjb3V0VGFibGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24i" + "xQEKE01lcmNlbmFyeVNjb3V0VGFibGUSEgoKYXBwZWFyUHJvYhgBIAEoBRIR" + "Cgljb3N0dW1lSWQYAiABKAUSCgoCaWQYAyABKAUSDgoGcGFja0lkGAQgASgF" + "EhgKEHByZXNlbnRJdGVtQ291bnQYBSADKAUSFQoNcHJlc2VudEl0ZW1JZBgG" + "IAMoBRIXCg9wcmVzZW50SXRlbVR5cGUYByADKAUSEwoLdGFsa0dyb3VwSWQY" + "CCABKAUSDAoEdHlwZRgJIAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFa" + "FS4vUHJvdG8uRGVzaWduLmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MercenaryScoutTable), MercenaryScoutTable.Parser, new string[9] { "AppearProb", "CostumeId", "Id", "PackId", "PresentItemCount", "PresentItemId", "PresentItemType", "TalkGroupId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
