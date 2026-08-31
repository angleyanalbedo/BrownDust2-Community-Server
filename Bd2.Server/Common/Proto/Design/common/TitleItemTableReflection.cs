using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class TitleItemTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjRjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL1RpdGxlSXRlbVRh" + "YmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIp4BCg5UaXRsZUl0ZW1U" + "YWJsZRINCgVncmFkZRgBIAEoBRIKCgJpZBgCIAEoBRIVCg10aXRsZUl0ZW1O" + "YW1lGAMgASgJEhoKEnRpdGxlTWlzc2lvblRleHRJZBgEIAEoBRIXCg90aXRs" + "ZU5hbWVUZXh0SWQYBSABKAkSFwoPdGl0bGVTb3J0TnVtYmVyGAYgASgFEgwK" + "BHR5cGUYByABKAVCREITUHJvdG8uRGVzaWduLmNvbW1vblABWhUuL1Byb3Rv" + "LkRlc2lnbi5jb21tb26qAhNQcm90by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(TitleItemTable), TitleItemTable.Parser, new string[7] { "Grade", "Id", "TitleItemName", "TitleMissionTextId", "TitleNameTextId", "TitleSortNumber", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
