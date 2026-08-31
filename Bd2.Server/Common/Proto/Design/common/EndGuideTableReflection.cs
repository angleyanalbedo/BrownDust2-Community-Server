using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class EndGuideTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CjVjb21tb24uZGIvVHV0b3JpYWxfX1/tipzthqDrpqzslrwvRW5kR3VpZGVU" + "YWJsZS5wcm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiLdAQoNRW5kR3VpZGVU" + "YWJsZRIRCglhdGxhc05hbWUYASABKAkSDwoHZ3JvdXBJZBgCIAEoBRIcChRn" + "dWlkZURlc2NMb2NhbFRleHRJZBgDIAEoBRIcChRndWlkZU5hbWVMb2NhbFRl" + "eHRJZBgEIAEoBRIYChBndWlkZVRleHR1cmVOYW1lGAUgASgJEgoKAmlkGAYg" + "ASgFEhcKD3NwaW5lUHJlZmFiTmFtZRgHIAEoCRISCgpzcHJpdGVOYW1lGAgg" + "ASgJEhkKEXZvaWNlUmVzb3VyY2VOYW1lGAkgASgJQkRCE1Byb3RvLkRlc2ln" + "bi5jb21tb25QAVoVLi9Qcm90by5EZXNpZ24uY29tbW9uqgITUHJvdG8uRGVz" + "aWduLmNvbW1vbmIGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(EndGuideTable), EndGuideTable.Parser, new string[9] { "AtlasName", "GroupId", "GuideDescLocalTextId", "GuideNameLocalTextId", "GuideTextureName", "Id", "SpinePrefabName", "SpriteName", "VoiceResourceName" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
