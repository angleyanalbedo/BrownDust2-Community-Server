using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class LobbySettingItemTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjtjb21tb24uZGIvSXRlbVRhYmxlX19f7JWE7J207YWcL0xvYmJ5U2V0dGlu" + "Z0l0ZW1UYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiKDAQoVTG9i" + "YnlTZXR0aW5nSXRlbVRhYmxlEhYKDmljb25TcHJpdGVOYW1lGAEgASgJEgoK" + "AmlkGAIgASgFEhYKDml0ZW1OYW1lVGV4dElkGAMgASgFEhAKCGl0ZW1QYXRo" + "GAQgASgJEg4KBnBhY2tJZBgFIAEoBRIMCgR0eXBlGAYgASgFQkRCE1Byb3Rv" + "LkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJv" + "dG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(LobbySettingItemTable), LobbySettingItemTable.Parser, new string[6] { "IconSpriteName", "Id", "ItemNameTextId", "ItemPath", "PackId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
