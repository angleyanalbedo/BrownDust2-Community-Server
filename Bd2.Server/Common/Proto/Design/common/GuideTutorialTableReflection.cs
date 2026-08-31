using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class GuideTutorialTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjpjb21tb24uZGIvVHV0b3JpYWxfX1/tipzthqDrpqzslrwvR3VpZGVUdXRv" + "cmlhbFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIo4BChJHdWlk" + "ZVR1dG9yaWFsVGFibGUSDwoHZ3JvdXBJZBgBIAEoBRISCgpndWlkZU9yZGVy" + "GAIgASgFEgoKAmlkGAMgASgFEhQKDHJlc291cmNlTmFtZRgEIAEoCRIXCg90" + "ZXh0TG9jYWxUZXh0SWQYBSABKAUSGAoQdGl0bGVMb2NhbFRleHRJZBgGIAEo" + "BUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWduLmNv" + "bW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(GuideTutorialTable), GuideTutorialTable.Parser, new string[6] { "GroupId", "GuideOrder", "Id", "ResourceName", "TextLocalTextId", "TitleLocalTextId" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
