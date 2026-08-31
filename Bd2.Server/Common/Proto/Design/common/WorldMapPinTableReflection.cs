using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Design.common;

public static class WorldMapPinTableReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9jb21tb24uZGIvTWFwVGFibGVfX1/rp7UvV29ybGRNYXBQaW5UYWJsZS5w" + "cm90bxITUHJvdG8uRGVzaWduLmNvbW1vbiL2AQoQV29ybGRNYXBQaW5UYWJs" + "ZRISCgpodW50UGFja0lkGAEgASgFEhwKFGh1bnRQaW5JY29TcHJpdGVOYW1l" + "GAIgASgJEhcKD2h1bnRUeXBlR3JvdXBJZBgDIAEoBRIKCgJpZBgEIAEoBRIZ" + "ChFtYXBEZXNjTmFtZVRleHRJZBgFIAEoBRIVCg1tYXBOYW1lVGV4dElkGAYg" + "ASgFEhwKFG1hcFBpbkljb25TcHJpdGVOYW1lGAcgASgJEh0KFW1hcFBpblRo" + "dW1iU3ByaXRlTmFtZRgIIAEoCRIOCgZwYWNrSWQYCSABKAUSDAoEdHlwZRgK" + "IAEoBUJEQhNQcm90by5EZXNpZ24uY29tbW9uUAFaFS4vUHJvdG8uRGVzaWdu" + "LmNvbW1vbqoCE1Byb3RvLkRlc2lnbi5jb21tb25iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(WorldMapPinTable), WorldMapPinTable.Parser, new string[10] { "HuntPackId", "HuntPinIcoSpriteName", "HuntTypeGroupId", "Id", "MapDescNameTextId", "MapNameTextId", "MapPinIconSpriteName", "MapPinThumbSpriteName", "PackId", "Type" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
