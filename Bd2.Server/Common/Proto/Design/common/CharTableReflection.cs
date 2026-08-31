using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class CharTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cjhjb21tb24uZGIvQ2hhclRhYmxlX19fQ2hhcl9Db3N0dW1lX1NraWxsL0No" + "YXJUYWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLxAwoJQ2hhclRh" + "YmxlEhQKDGNoYXJHcm93dGhJZBgBIAEoBRIWCg5jaGFyTmFtZVRleHRJZBgC" + "IAEoBRIbChNjcml0aWNhbENoYW5jZVZhbHVlGAMgASgBEh8KF2NyaXRpY2Fs" + "RGFtYWdlUmF0ZVZhbHVlGAQgASgBEhgKEGRlZmF1bHRDb3N0dW1lSWQYBSAB" + "KAUSDwoHZWxlbWVudBgGIAEoBRIbChNlbGVtZW50RGVmZW5zZVZhbHVlGAcg" + "ASgBEhkKEWVsZW1lbnRQb3dlclZhbHVlGAggASgBEg0KBWdyYWRlGAkgASgF" + "EhMKC2dyb3d0aGdyYWRlGAogASgFEhMKC2hlYWx0aFZhbHVlGAsgASgBEgoK" + "AmlkGAwgASgFEhkKEW1hZ2ljRGVmZW5zZVZhbHVlGA0gASgBEhcKD21hZ2lj" + "UG93ZXJWYWx1ZRgOIAEoARISCgpuZXh0Q2hhcklkGA8gASgFEhwKFHBoeXNp" + "Y2FsRGVmZW5zZVZhbHVlGBAgASgBEhoKEnBoeXNpY2FsUG93ZXJWYWx1ZRgR" + "IAEoARIQCgh0YWxlbnRJZBgSIAEoBRIMCgR0eXBlGBMgASgFEhQKDHVuaXF1" + "ZUNoYXJJZBgUIAEoBRIYChB1c2VQYWNrVGVtcG9yYXJ5GBUgASgFQkRCE1By" + "b3RvLkRlc2lnbi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgIT" + "UHJvdG8uRGVzaWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(CharTable), CharTable.Parser, new string[21]
		{
			"CharGrowthId", "CharNameTextId", "CriticalChanceValue", "CriticalDamageRateValue", "DefaultCostumeId", "Element", "ElementDefenseValue", "ElementPowerValue", "Grade", "Growthgrade",
			"HealthValue", "Id", "MagicDefenseValue", "MagicPowerValue", "NextCharId", "PhysicalDefenseValue", "PhysicalPowerValue", "TalentId", "Type", "UniqueCharId",
			"UsePackTemporary"
		}, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
