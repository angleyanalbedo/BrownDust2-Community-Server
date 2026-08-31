using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CharLevelTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cj1jb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0No" + "YXJMZXZlbFRhYmxlLnByb3RvEhNQcm90by5EZXNpZ24uY29tbW9uIpcCCg5D" + "aGFyTGV2ZWxUYWJsZRIWCg5jcml0aWNhbENoYW5jZRgBIAEoARIaChJjcml0" + "aWNhbERhbWFnZVJhdGUYAiABKAESGwoTZWxlbWVudERlZmVuc2VWYWx1ZRgD" + "IAEoARIZChFlbGVtZW50UG93ZXJWYWx1ZRgEIAEoARIPCgdncm91cElkGAUg" + "ASgFEg4KBmhlYWx0aBgGIAEoARIKCgJpZBgHIAEoBRISCgpsZXZlbHVwRXhw" + "GAggASgFEhQKDG1hZ2ljRGVmZW5zZRgJIAEoARISCgptYWdpY1Bvd2VyGAog" + "ASgBEhcKD3BoeXNpY2FsRGVmZW5zZRgLIAEoARIVCg1waHlzaWNhbFBvd2Vy" + "GAwgASgBQkRCE1Byb3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNp" + "Z24uY29tbW9uqgITUHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharLevelTable), CharLevelTable.Parser, new string[12]
		{
			"CriticalChance", "CriticalDamageRate", "ElementDefenseValue", "ElementPowerValue", "GroupId", "Health", "Id", "LevelupExp", "MagicDefense", "MagicPower",
			"PhysicalDefense", "PhysicalPower"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
