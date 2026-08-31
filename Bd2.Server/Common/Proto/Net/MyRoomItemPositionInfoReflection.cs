using System;
using Google.Protobuf.Reflection;

namespace Bd2.Server.Common.Proto.Net;

public static class MyRoomItemPositionInfoReflection
{
	private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRDb21tb25zL015Um9vbUl0ZW1Qb3NpdGlvbkluZm8ucHJvdG8SCXByb3Rv" + "Lm5ldCKpAQoWTXlSb29tSXRlbVBvc2l0aW9uSW5mbxITCgtpbnZlbl9pbmRl" + "eBgBIAEoAxITCgtvYmplY3RfdHlwZRgCIAEoBRIVCg1wb3NpdGlvbl90eXBl" + "GAMgASgFEgkKAXgYBCABKAUSCQoBeRgFIAEoBRIOCgZyb3RhdGUYBiABKAUS" + "EAoIaW50ZXJhY3QYByABKAUSFgoOaXRlbV9hbmltYXRpb24YCCABKAViBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
	{
		new GeneratedClrTypeInfo(typeof(MyRoomItemPositionInfo), MyRoomItemPositionInfo.Parser, new string[8] { "InvenIndex", "ObjectType", "PositionType", "X", "Y", "Rotate", "Interact", "ItemAnimation" }, null, null, null, null)
	}));

	public static FileDescriptor Descriptor => descriptor;
}
