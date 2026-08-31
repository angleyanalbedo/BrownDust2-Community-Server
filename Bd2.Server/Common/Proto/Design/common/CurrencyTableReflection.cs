using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CurrencyTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjNjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL0N1cnJlbmN5VGFi" + "bGUucHJvdG8SE1Byb3RvLkRlc2lnbi5jb21tb24itwEKDUN1cnJlbmN5VGFi" + "bGUSGwoTaWNvblNwcml0ZU5hbWVMYXJnZRgBIAEoCRIbChNpY29uU3ByaXRl" + "TmFtZVNtYWxsGAIgASgJEgoKAmlkGAMgASgFEhoKEml0ZW1EZXNjTmFtZVRl" + "eHRJZBgEIAEoBRIWCg5pdGVtTmFtZVRleHRJZBgFIAEoBRIUCgx0YXJnZXRJ" + "dGVtSWQYBiABKAUSFgoOdGFyZ2V0SXRlbVR5cGUYByABKAVCREITUHJvdG8u" + "RGVzaWduLmNvbW1vblABWhUuL1Byb3RvLkRlc2lnbi5jb21tb26qAhNQcm90" + "by5EZXNpZ24uY29tbW9uYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CurrencyTable), CurrencyTable.Parser, new string[7] { "IconSpriteNameLarge", "IconSpriteNameSmall", "Id", "ItemDescNameTextId", "ItemNameTextId", "TargetItemId", "TargetItemType" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
